package com.example.kanban_board.Models;

public class Ticket {

    private String People;
    private String Ticket;
    private String Title;
    private String status;
    private String boards;

    public Ticket() {
    }

    public Ticket(String People, String Ticket, String Title) {
        this.People = People;
        this.Ticket = Ticket;
        this.Title = Title;
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


    public void setPeople(String People) {
        this.People = People;
    }

    public void setTicket(String Ticket) {
        this.Ticket = Ticket;
    }

    public void setTitle(String Title) {
        this.Title = Title;
    }

    public String getStatus() {
        return status;
    }

    public void setStatus(String status) {
        this.status = status;
    }

    public String getBoards() {
        return boards;
    }

    public void setBoards(String boards) {
        this.boards = boards;
    }
}
