using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace kanbanboard.Classes
{
    internal static class Firebase
    {
        // Инициализация Firebase клиента
        public static string Secret { get; }
        public static string Path { get; }
        public static IFirebaseClient Client { get; }

        static Firebase()
        {
            Secret = "hebNTLDeI3UdiZnzjsM8qRxJufACuQJIgRsCfroW";
            Path = "https://kanban-2e9a3-default-rtdb.europe-west1.firebasedatabase.app/";
            Client = new FirebaseClient(new FirebaseConfig { AuthSecret = Secret, BasePath = Path });
        }

        // Получить роль пользователя
        public static Roles GetRole(this User user)
        {
            string role = Client.GetAsync($"Users/{user.Username}/Role").Result?.ResultAs<string>();
            if (role is not null)
            {
                return role.ToEnum<Roles>();
            }

            Client.SetAsync($"Users/{user.Username}/Role", "User");
            return "User".ToEnum<Roles>();
        }

        // Получаем имена проектов и их данные канбан доски
        // Словарь с данными.
        // [ключ — НАЗВАНИЕ ПРОЕКТА | значение — ДАННЫЕ КАНБАН-ДОСКИ (тоже в виде словаря)]
        public static Dictionary<string, Dictionary<string, List<Dictionary<string, string>>>> GetDataForAllProjects(this User user)
        {
            Dictionary<string, Dictionary<string, List<Dictionary<string, string>>>> dataOfProjects = new();

            // Получаем имена проектов пользователя. Очищаем значения с null
            List<string> projects = Client.GetAsync($"Users/{user.Username}/Projects").Result.ResultAs<List<string>>() ?? new List<string>();
            projects.RemoveAll(x => x is null);

            foreach (string p in projects)
            {
                // Получаем канбан-доску проекта, если он есть в базе
                Dictionary<string, List<Dictionary<string, string>>> kanban = Client.GetAsync($"Projects/{p}/Kanban").Result.ResultAs<Dictionary<string, List<Dictionary<string, string>>>>();
                if (kanban == null)
                {
                    continue;
                }

                // clear nulls
                kanban.Values.ToList().ForEach(x => x.RemoveAll(y => y is null));

                // Добавляем данные в словарь
                dataOfProjects.Add(p, kanban);
            }

            return dataOfProjects;
        }

        // Загрузить данные
        public static void UploadData(Dictionary<string, Dictionary<string, List<Dictionary<string, string>>>> dataDictionary)
        {
            foreach (KeyValuePair<string, Dictionary<string, List<Dictionary<string, string>>>> project in dataDictionary)
            {
                Client.Set($"Projects/{project.Key}/Kanban", project.Value);
            }
        }

        // Получить имена всех проектов пользователя
        public static List<string> GetProjectNames(this User user)
        {
            try
            {
                List<string> data = Client.GetAsync($"Users/{user.Username}/Projects").Result.ResultAs<List<string>>() ?? new List<string>();
                data.RemoveNullsFromData();
                return data;
            }
            catch { return null; }
        }

        // Получить пароль профиля
        public static string GetPassword(this User user)
        {
            try
            {
                return Client.GetAsync($"Users/{user.Username}/Password").Result.ResultAs<string>();
            }
            catch
            {
                return null;
            }
        }

        // Создает проект в базе пользователя.
        public static async Task<string> CreateProject(this User user, string projectName)
        {
            List<string> data = Client.Get($"Users/{user.Username}/Projects").ResultAs<List<string>>();

            // Вытаскиваем данные о проектах, либо заносим, если их нет
            if (data is not null)
            {
                data.RemoveNullsFromData();

                // Добавляем в данные данные
                if (!data.Exists(x => x == projectName))
                {
                    data.Add(projectName);
                }

                // добавляем в базу
                SetResponse result = await Client.SetAsync($"Users/{user.Username}/Projects", data);

                return result.StatusCode.ToString();
            }

            var response = await Client.SetAsync($"Users/{user.Username}/Projects", new List<string> { projectName });

            return response.StatusCode.ToString();
        }

        // Удаляет проект из базы пользователя.
        public static async Task<string> DeleteProject(this User user, string projectName)
        {
            // Вытаскиваем данные
            var data = Client.GetAsync($"Users/{user.Username}/Projects").Result.ResultAs<List<string>>();

            data.RemoveAll(x => x == projectName);

            // удаляем из базы
            SetResponse result = await Client.SetAsync($"Users/{user.Username}/Projects", data);

            return result.StatusCode.ToString();
        }

        public static Dictionary<string, User> GetAllUsers()
        {
            return Client.Get("Users/").ResultAs<Dictionary<string, User>>();
        }

        // Получить все сообщения проекта
        public static List<Dictionary<string, string>> GetMessages(this User user, string projectName)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            try
            {
                return Client.GetAsync($"Projects/{projectName}/Chat/").Result.ResultAs<List<Dictionary<string, string>>>();
            }
            catch
            {
                return null;
            }
        }

        // Сохранить сообщение в базу
        public static async Task<string> SaveMessage(this User user, string projectName, string message)
        {
            var list = user.GetMessages(projectName) ?? new List<Dictionary<string, string>>();
            list.Add(new Dictionary<string, string> { { user.Username, message } });
            
            var result = await Client.SetAsync($"Projects/{projectName}/Chat/", list);

            return result.StatusCode.ToString();
        }

        public static async Task<string> CreateUser(this User user)
        {
            var response = await Client.SetAsync($"Users/{user.Username}/", user);

            return response.StatusCode.ToString();
        }

        public static async Task<string> GetDeadline(string projectName)
        {
            var response = await Client.GetAsync($"Projects/{projectName}/Deadline");

            return response.ResultAs<string>();
        }

        public static async Task<string> SetDeadline(DateTime date, string projectName)
        {
            var response = await Client.SetAsync($"Projects/{projectName}/Deadline", $"{date.Day}.{date.Month}.{date.Year}");

            return response.StatusCode.ToString();
        }
    }
}