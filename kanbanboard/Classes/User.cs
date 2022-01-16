using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace kanbanboard.Classes
{
    public enum Roles
    {
        Admin,
        User,
        Manager,
        Programmer
    }

    public class User
    {
        public string Username { get; set; }
        public List<string> Projects { get; set; }
        [JsonConverter(typeof(StringEnumConverter))] public Roles Role { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Dictionary<string, Dictionary<string, List<Dictionary<string, string>>>> GetProjectsData() => this.GetDataForAllProjects();
        public List<string> ProjectNames() => this.GetProjectNames();

        public User(string username)
        {
            Username = username;
            Role = this.GetRole();
            Password = this.GetPassword();
        }

        [JsonConstructor]
        public User(string username, string password, string email, List<string> projects, Roles role)
        {
            Username = username;
            Password = password;
            Email = email;
            Projects = projects;
            Role = role;
        }
    }
}
