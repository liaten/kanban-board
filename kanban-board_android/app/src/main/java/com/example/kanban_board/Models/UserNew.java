package com.example.kanban_board.Models;

public class UserNew {

    public String role, password, login, email;

    public UserNew() {
    }

    public UserNew(String role, String password, String login, String email) {
        this.role = role;
        this.password = password;
        this.login = login;
        this.email = email;
    }

    public UserNew(String role, String password, String login) {
        this.role = role;
        this.password = password;
        this.login = login;
    }

    public String getLogin() {
        return login;
    }

    public void setLogin(String login) {
        this.login = login;
    }

    public String getRole() {
        return role;
    }

    public void setRole(String role) {
        this.role = role;
    }


    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }
}
