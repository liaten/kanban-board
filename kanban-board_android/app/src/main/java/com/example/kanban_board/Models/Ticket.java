package com.example.kanban_board.Models;

public class Ticket {

    private String People;
    private String Ticket;
    private String Title;
    private String Status;
    private String boards;

    public Ticket() {
    }

    public Ticket(String People, String Ticket, String Title) {
        this.People = People;
        this.Ticket = Ticket;
        this.Title = Title;
    }

    public Ticket(String People, String Ticket, String Title, String Status) {
        this.People = People;
        this.Ticket = Ticket;
        this.Title = Title;
        this.Status = Status;
    }

    public String getpeople() {
        return People;
    }

    public String getticket() {
        return Ticket;
    }

    public String gettitle() {
        return Title;
    }

    public String getstatus() {
        return Status;
    }

    public void setPeople(String People) {
        this.People = People;
    }

    public void setTicket(String Ticket) {
        this.Ticket = Ticket;
    }

    public void setTitle(String Title) {
        this.Title = Title;
    }

    public void setStatus(String status) {
        this.Status = status;
    }

    public String getBoards() {
        return boards;
    }

    public void setBoards(String boards) {
        this.boards = boards;
    }
}
