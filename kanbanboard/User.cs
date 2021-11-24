using System;
using System.Collections.Generic;
using System.Linq;

namespace kanbanboard
{
    internal class User
    {
        public string Username { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }

        public Dictionary<string, Dictionary<string, List<Dictionary<string, string>>>> ProjectsData
        {
            get => this.GetDataForAllProjects();
            set
            {
                if (value.Count == 0) throw new ArgumentException("Value cannot be an empty collection.", nameof(value));
                ProjectsData = value;
            }
        }

        public List<string> ProjectNames { get; set; }

        public User() : this(LoginForm.Username) { }

        public User(string username)
        {
            Username = username;
            Role = this.GetRole();
            Password = this.GetPassword();
            ProjectNames = this.GetProjectNames();
        }
    }
}
