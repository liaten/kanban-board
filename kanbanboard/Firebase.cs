using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace kanbanboard
{
    static class Firebase
    {
        // Инициализация Firebase клиента
        public static string Secret { get; private set; }
        public static string Path { get; private set; }
        public static IFirebaseClient Client { get; private set; }

        static Firebase()
        {
            Secret = "hebNTLDeI3UdiZnzjsM8qRxJufACuQJIgRsCfroW";
            Path = "https://kanban-2e9a3-default-rtdb.europe-west1.firebasedatabase.app/";
            Client = new FirebaseClient(new FirebaseConfig() { AuthSecret = Secret, BasePath = Path });
        }

        // Получаем имена проектов и их данные канбан доски
        // Словарь с данными.
        // [ключ — НАЗВАНИЕ ПРОЕКТА | значение — ДАННЫЕ КАНБАН-ДОСКИ (тоже в виде словаря)]
        public static Dictionary<string, Dictionary<string, List<Dictionary<string, string>>>> GetProjectsData(this User user)
        {
            var dataOfProjects = new Dictionary<string, Dictionary<string, List<Dictionary<string, string>>>>();

            // Получаем имена проектов пользователя. Очищаем значения с null
            var projects = Client.Get($"Users/{user.Username}/Projects").ResultAs<List<string>>() ?? new List<string>();
            projects.RemoveAll(x => x is null);

            foreach (var p in projects)
            {
                // Получаем канбан-доску проекта, если он есть в базе
                var kanban = Client.Get($"{p}").ResultAs<Dictionary<string, List<Dictionary<string, string>>>>();
                if (kanban == null) continue;

                // clear nulls
                kanban.Values.ToList().ForEach(x => x.RemoveAll(y => y is null));

                // Добавляем данные в словарь
                dataOfProjects.Add(p, kanban);
            }

            return dataOfProjects;
        }

        // Получить имена всех проектов пользователя
        public static List<string> GetProjectNames(this User user)
        {
            try { return Client.Get($"Users/{user.Username}/Projects").ResultAs<List<string>>() ?? new List<string>(); }
            catch { return null; }
        }

        // Получить пароль профиля
        public static string GetPassword(this User user)
        {
            try { return Client.Get($"Users/{user.Username}/password").Body; }
            catch { return null; }
        }

        // Создает проект в базе пользователя.
        public static void CreateProject(this User user, string projectName)
        {
            // Вытаскиваем данные о проектах, либо заносим, если их нет
            if (Client.Get($"Users/{user.Username}/Projects").ResultAs<List<string>>() is null)
            {
                Client.Set($"Users/{user.Username}/Projects", new List<string> { projectName });
                return;
            }
            var data = Client.Get($"Users/{user.Username}/Projects").ResultAs<List<string>>();

            // Добавляем в данные данные
            if (!data.Exists(x => x == projectName))
                data.Add(projectName);

            // добавляем в базу
            Client.Set($"Users/{user.Username}/Projects", data);
        }

        // Удаляет проект из базы пользователя.
        public static void DeleteProject(this User user, string projectName)
        {
            // Вытаскиваем данные
            var data = Client.Get($"Users/{user.Username}/projects").ResultAs<List<string>>();

            data.RemoveAll(x => x == projectName);

            // удаляем из базы
            Client.Set($"Users/{user.Username}/projects", data);
        }
    }
}