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

public class MyAdapterForCalendar extends RecyclerView.Adapter<MyAdapterForCalendar.MyViewHolderForCalendar> {


    Context context;

    ArrayList<Ticket> list;


    public MyAdapterForCalendar(Context context, ArrayList<Ticket> list) {
        this.context = context;
        this.list = list;
    }

    @NonNull
    @Override
    public MyViewHolderForCalendar onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View v = LayoutInflater.from(context).inflate(R.layout.ticket_item_calendar, parent, false);
        return new MyViewHolderForCalendar(v);
    }

    @Override
    public void onBindViewHolder(@NonNull MyViewHolderForCalendar holder, int position) {

        Ticket ticket = list.get(position);
        holder.Title.setText(ticket.getTitle());
        holder.Ticket.setText(ticket.getTicket());
        holder.People.setText(ticket.getPeople());
        holder.Status.setText(ticket.getStatus());

    }


    @Override
    public int getItemCount() {
        return list.size();
    }

    public static class MyViewHolderForCalendar extends RecyclerView.ViewHolder{

        TextView Title, Ticket, People, Status;


        public MyViewHolderForCalendar(@NonNull View itemView) {
            super(itemView);

            Title = itemView.findViewById(R.id.ticketTitle);
            Ticket = itemView.findViewById(R.id.ticketText);
            People = itemView.findViewById(R.id.ticketPeople);
            Status = itemView.findViewById(R.id.ticketStatus);

        }


    }




}
