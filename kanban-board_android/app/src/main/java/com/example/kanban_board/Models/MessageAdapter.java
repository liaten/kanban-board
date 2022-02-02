package com.example.kanban_board.Models;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.kanban_board.R;

import java.util.ArrayList;

public class MessageAdapter extends RecyclerView.Adapter<MessageAdapter.ViewHolderForMessages> {

    Context context;
    ArrayList<UserMessage> messageList;

    public MessageAdapter(Context context, ArrayList<UserMessage> messageList) {
        this.context = context;
        this.messageList = messageList;
    }

    @NonNull
    @Override
    public MessageAdapter.ViewHolderForMessages onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View v = LayoutInflater.from(context).inflate(R.layout.message_item, parent, false);
        return new MessageAdapter.ViewHolderForMessages(v);
    }
    @Override
    public void onBindViewHolder(@NonNull MessageAdapter.ViewHolderForMessages holder, int position) {
        UserMessage message = messageList.get(position);
        holder.Sender.setText(message.getSender());
        holder.Text.setText(message.getText());
    }
    @Override
    public int getItemCount() {
        return messageList.size();
    }
    public static class ViewHolderForMessages extends RecyclerView.ViewHolder{
        TextView Sender, Text;
        public ViewHolderForMessages(@NonNull View itemView) {
            super(itemView);
            Sender = itemView.findViewById(R.id.messageSender);
            Text = itemView.findViewById(R.id.messageText);
        }

    }

}
