package kanban.board.Models;

public class Ticket {

    private String People;
    private String Ticket;
    private String Title;
    private String Status;
    private String Boards;

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

    public String getPeople() {
        return this.People;
    }

    public String getTicket() {
        return this.Ticket;
    }

    public String getTitle() {
        return this.Title;
    }

    public String getStatus() {
        return this.Status;
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
        return this.Boards;
    }

    public void setBoards(String Boards) {
        this.Boards = Boards;
    }
}
