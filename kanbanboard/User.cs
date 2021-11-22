using System.Collections.Generic;

namespace kanbanboard
{
    internal class User
    {
        public string Username { get; private set; }
        public string Password { get; private set; }
        public Dictionary<string, Dictionary<string, List<Dictionary<string, string>>>> ProjectsData { get; }
        public User() : this("kosdr77") { }
        
        public User(string username)
        {
            Username = username;
            Password = this.GetPassword();
            ProjectsData = this.GetProjectsData();
        }
    }
}
