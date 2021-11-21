using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace kanbanboard
{
    static class Firebase
    {
        public static string Secret { get; private set; } = "hebNTLDeI3UdiZnzjsM8qRxJufACuQJIgRsCfroW";
        public static string Path { get; private set; } = "https://kanban-2e9a3-default-rtdb.europe-west1.firebasedatabase.app/";
        public static IFirebaseClient Client { get; private set; } = new FirebaseClient(new FirebaseConfig() { AuthSecret = Secret, BasePath = Path });
        public static string Username { get; private set; }

        static Firebase()
        {
            Username = Login.Username;
            //var response = Client.Get("Company/Accounts").ResultAs<>();
        }

        private static void Update()
        {

        }
    }
    static class FirebaseInformation
    {
        public static List<string> Company { get; set; }
    }
}
