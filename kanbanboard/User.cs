using System.Collections.Generic;
using System.Linq;

namespace kanbanboard
{
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Dictionary<string, Dictionary<string, List<Dictionary<string, string>>>> ProjectsData { get; set; }
        public List<string> ProjectNames { get; set; }

        // public User() : this(Login.Username) { }
        public User() : this("kosdr77") { }

        public User(string username)
        {
            Username = username;
            Password = this.GetPassword();
            ProjectsData = this.GetDataForAllProjects();
            ProjectNames = this.GetProjectNames();
        }
    }
}
