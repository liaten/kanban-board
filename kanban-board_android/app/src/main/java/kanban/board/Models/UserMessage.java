package kanban.board.Models;

public class UserMessage {

    private String Sender;
    private String Text;

    public UserMessage(String sender, String text) {
        Sender = sender;
        Text = text;
    }

    public UserMessage() {
    }

    public String getSender() {
        return Sender;
    }

    public void setSender(String sender) {
        Sender = sender;
    }

    public String getText() {
        return Text;
    }

    public void setText(String text) {
        Text = text;
    }
}
