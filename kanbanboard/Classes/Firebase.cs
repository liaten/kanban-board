using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kanbanboard.Classes
{
    static class Firebase
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

        public static void RemoveNullsFromData(this List<string> data) => data.RemoveAll(x => x is null);

        // Получить роль пользователя
        public static Roles GetRole(this User user)
        {
            string role = Client.GetAsync($"Users/{user.Username}/Role").Result.ResultAs<string>();
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
            Dictionary<string, Dictionary<string, List<Dictionary<string, string>>>> dataOfProjects =
                new Dictionary<string, Dictionary<string, List<Dictionary<string, string>>>>();

            // Получаем имена проектов пользователя. Очищаем значения с null
            List<string> projects = Client.GetAsync($"Users/{user.Username}/Projects").Result.ResultAs<List<string>>() ?? new List<string>();
            projects.RemoveAll(x => x is null);

            foreach (string p in projects)
            {
                // Получаем канбан-доску проекта, если он есть в базе
                Dictionary<string, List<Dictionary<string, string>>> kanban =
                    Client.GetAsync($"Projects/{p}/Kanban").Result.ResultAs<Dictionary<string, List<Dictionary<string, string>>>>();
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

        // Получить данные одного проекта
        public static Dictionary<string, List<Dictionary<string, string>>> GetProjectData(string projectName)
        {
            // Получаем канбан-доску проекта, если он есть в базе
            Dictionary<string, List<Dictionary<string, string>>> data =
                Client.GetAsync($"Projects/{projectName}/Kanban").Result.ResultAs<Dictionary<string, List<Dictionary<string, string>>>>();
            if (data == null) return null;

            // clear nulls
            data.Values.ToList().ForEach(x => x.RemoveAll(y => y is null));

            return data;
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

        public static string GetPassword(this string username)
        {
            try
            {
                return Client.GetAsync($"Users/{username}/Password").Result.ResultAs<string>();
            }
            catch
            {
                return null;
            }
        }

        // Проверка пароля.
        // Если пароля нет в базе, пользователь входит в любом случае (хоть с липовым паролем, хоть без него)
        public static bool CheckPassword(this User user, string potentialPassword)
        {
            string password = user.GetPassword();
            if (password is null) return true;
            return password == potentialPassword;
        }

        public static bool CheckPassword(this string username, string potentialPassword)
        {
            string password = GetPassword(username);
            return password is null || password == potentialPassword;
        }

        // Установить пароль пользователю
        public static void SetPassword(this User user, string password)
        {
            if (Client.Get($"Users/{user.Username}/Password").ResultAs<string>() is null)
            {
                Client.SetAsync($"Users/{user.Username}/Password", password);
            }
            else
            {
                Client.SetAsync($"Users/{user.Username}/Password", password);
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
                FireSharp.Response.SetResponse result = await Client.SetAsync($"Users/{user.Username}/Projects", data);

                return result.StatusCode.ToString();
            }
            await Client.SetAsync($"Users/{user.Username}/Projects", new List<string> { projectName });
            return null;
        }

        // Создает проект в базе пользователя.
        public static async void CreateProject(this string username, string projectName)
        {
            List<string> data = Client.Get($"Users/{username}/Projects").ResultAs<List<string>>();

            // Вытаскиваем данные о проектах, либо заносим, если их нет
            if (data is null)
            {
                await Client.SetAsync($"Users/{username}/Projects", new List<string> { projectName });
                return;
            }

            data.RemoveNullsFromData();

            // Добавляем в данные данные
            if (!data.Exists(x => x == projectName))
            {
                data.Add(projectName);
            }

            // добавляем в базу
            await Client.SetAsync($"Users/{username}/Projects", data);
        }

        public static async void CreateProjects(this string username, List<string> projectNames)
        {
            // добавляем в базу
            await Client.SetAsync($"Users/{username}/Projects", projectNames);
        }

        // Удаляет проект из базы пользователя.
        public static async Task<string> DeleteProject(this User user, string projectName)
        {
            // Вытаскиваем данные
            List<string> data = Client.GetAsync($"Users/{user.Username}/Projects").Result.ResultAs<List<string>>();

            data.RemoveAll(x => x == projectName);

            // удаляем из базы
            FireSharp.Response.SetResponse result = await Client.SetAsync($"Users/{user.Username}/Projects", data);

            return result.StatusCode.ToString();
        }

        public static Dictionary<string, User> GetAllUsers()
        {
            return Client.Get("Users/").ResultAs<Dictionary<string, User>>();
        }

        public static bool CheckUser(this string username)
        {
            string response = Client.GetAsync($"Users/{username}").Result.Body;
            return response != "null" && !string.IsNullOrEmpty(response);
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
        public static async void SaveMessage(this User user, string projectName, string message)
        {
            List<Dictionary<string, string>> list =
                user.GetMessages(projectName) ?? new List<Dictionary<string, string>>();
            list.Add(new Dictionary<string, string> { { user.Username, message } });
            await Client.SetAsync($"Projects/{projectName}/Chat/", list);
        }

        public static async void CreateUser(this string username, string password, List<string> projectsNames = null, string email = "")
        {
            await Client.SetAsync($"Users/{username}/", new Dictionary<string, string>
            {
                {"password", MD5.Encrypt(password) },
                { "Role", "User"},
            });
            if (!(projectsNames is null))
            {
                await Client.UpdateAsync($"Users/{username}/", new Dictionary<string, List<string>> { { "Projects", projectsNames } });
            }

            if (!string.IsNullOrEmpty(email))
            {
                await Client.UpdateAsync($"Users/{username}/", new Dictionary<string, string> { { "Email", email } });
            }
        }

        public static async void CreateUser(this User user)
        {
            await Client.SetAsync($"Users/{user.Username}/", user);
        }
    }
}