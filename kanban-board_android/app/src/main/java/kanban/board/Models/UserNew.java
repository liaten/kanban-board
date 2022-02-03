package kanban.board.Models;

public class UserNew {

    private String Role, Password, Username, Email, Organization, FullName;

    public UserNew() {
    }

    public UserNew(String Role, String Password, String Username, String Email, String Organization, String FullName) {
        this.Role = Role;
        this.Password = Password;
        this.Username = Username;
        this.Email = Email;
        this.Organization = Organization;
        this.FullName = FullName;
    }

    public String getRole() {
        return this.Role;
    }

    public void setRole(String Role) {
        this.Role = Role;
    }

    public String getPassword() {
        return this.Password;
    }

    public void setPassword(String Password) {
        this.Password = Password;
    }

    public String getUsername() {
        return this.Username;
    }

    public void setUsername(String Username) {
        this.Username = Username;
    }

    public String getEmail() {
        return this.Email;
    }

    public void setEmail(String Email) {
        this.Email = Email;
    }

    public String getOrganization() {
        return this.Organization;
    }

    public void setOrganization(String Organization) {
        this.Organization = Organization;
    }

    public String getFullName() {
        return this.FullName;
    }

    public void setFullName(String FullName) {
        this.FullName = FullName;
    }
}
