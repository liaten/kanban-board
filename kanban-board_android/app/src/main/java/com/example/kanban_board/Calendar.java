package com.example.kanban_board;

import android.content.DialogInterface;
import android.content.Intent;
import android.icu.text.CaseMap;
import android.os.Bundle;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AlertDialog;
import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.ItemTouchHelper;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.text.TextUtils;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.LinearLayout;
import android.widget.ListView;
import android.widget.ScrollView;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import com.example.kanban_board.Models.MyAdapterForCalendar;
import com.example.kanban_board.Models.Ticket;
import com.example.kanban_board.Models.User;
import com.example.kanban_board.Models.UserNew;
import com.google.android.gms.common.server.converter.StringToIntConverter;
import com.google.android.material.snackbar.Snackbar;
import com.google.firebase.auth.AuthResult;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseAuthException;
import com.google.firebase.auth.FirebaseUser;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.Query;
import com.google.firebase.database.ValueEventListener;
import com.rengwuxian.materialedittext.MaterialEditText;

import java.util.ArrayList;
import java.util.List;


public class Calendar extends Fragment {

    private static final String ARG_PARAM1 = "param1";
    private static final String ARG_PARAM2 = "param2";

    private String mParam1;
    private String mParam2;

    RecyclerView recyclerView;
    DatabaseReference database;
    MyAdapterForCalendar adapter;
    ArrayList<Ticket> list;

    Spinner spinner;
    DatabaseReference dbBoards;
    String boardName = "";

    Button addBoardBtn;
    LinearLayout root;
    DatabaseReference boards;

    Button addTicketBtn;
    DatabaseReference tickets;

    TextView Header;

    Integer myNum = 0;
    DatabaseReference itemsRef;

    Integer myNumTicket = 0;


    String ticketName;
    String ticketText;
    String ticketPeople;
    String ticketStatus;
    String ticketBoardName;

    public Calendar() {
        // Required empty public constructor
    }

    public static Calendar newInstance(String param1, String param2) {
        Calendar fragment = new Calendar();
        Bundle args = new Bundle();
        args.putString(ARG_PARAM1, param1);
        args.putString(ARG_PARAM2, param2);
        fragment.setArguments(args);
        return fragment;
    }

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        if (getArguments() != null) {
            mParam1 = getArguments().getString(ARG_PARAM1);
            mParam2 = getArguments().getString(ARG_PARAM2);
        }
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        ViewGroup viewGroup = (ViewGroup) inflater.inflate(R.layout.fragment_calendar, container, false);

        recyclerView = (RecyclerView) viewGroup.findViewById(R.id.ticketList);
        spinner = (Spinner) viewGroup.findViewById(R.id.spinnerBoards);
        addBoardBtn = (Button) viewGroup.findViewById(R.id.addBoardBtn);
        addTicketBtn = (Button) viewGroup.findViewById(R.id.addTicketBtn);
        root = (LinearLayout) viewGroup.findViewById(R.id.calendar_root_layout);
        Header = (TextView) viewGroup.findViewById(R.id.headerCalender);

        ItemTouchHelper itemTouchHelper = new ItemTouchHelper(simpleCallback);
        itemTouchHelper.attachToRecyclerView(recyclerView);


        TestGet();
        GetBoards();
        GetTicketsFromSpinner();
        AddBoard();
        AddTicket();


        return viewGroup;
        //return inflater.inflate(R.layout.fragment_calendar, container, false);
    }

    //Свайпы(удаление)
    ItemTouchHelper.SimpleCallback simpleCallback = new ItemTouchHelper.SimpleCallback(0, ItemTouchHelper.LEFT) {
        @Override
        public boolean onMove(@NonNull RecyclerView recyclerView, @NonNull RecyclerView.ViewHolder viewHolder, @NonNull RecyclerView.ViewHolder target) {
            return false;
        }

        @Override
        public void onSwiped(@NonNull RecyclerView.ViewHolder viewHolder, int direction) {

            int position = viewHolder.getAdapterPosition();

            switch (direction){

                case ItemTouchHelper.LEFT:

                    String ticketBoardName = spinner.getSelectedItem().toString();
                    Ticket ticket = list.get(position);
                    String titleDB = ticket.gettitle();
                    String ticketStatus = ticket.getstatus();

                    DatabaseReference dReference = FirebaseDatabase.getInstance().getReference();

                    Query delQuery = dReference.child("Projects").child(ticketBoardName).child("Kanban").child(ticketStatus).orderByChild("title").equalTo(titleDB);
                    delQuery.addListenerForSingleValueEvent(new ValueEventListener() {
                        @Override
                        public void onDataChange(DataSnapshot dataSnapshot) {
                            for (DataSnapshot delSnapshot: dataSnapshot.getChildren()) {
                                delSnapshot.getRef().removeValue();
                            }
                        }

                        @Override
                        public void onCancelled(DatabaseError databaseError) {

                        }
                    });

                    list.remove(position);
                    adapter.notifyItemRemoved(position);
                    break;

            }

        }
    };

    //добавить тикет
    private void AddTicket() {

        addTicketBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                AlertDialog.Builder addT = new AlertDialog.Builder(getActivity());
                addT.setTitle("Добавление нового тикета");
                addT.setMessage("Введите название тикета");

                LayoutInflater inflater = LayoutInflater.from(getActivity());
                View addT_window = inflater.inflate(R.layout.add_new_ticket, null);
                addT.setView(addT_window);

                final MaterialEditText name = addT_window.findViewById(R.id.addTicketName);
                final MaterialEditText text = addT_window.findViewById(R.id.addTicketText);
                final MaterialEditText people = addT_window.findViewById(R.id.addTicketPeople);
                final MaterialEditText status = addT_window.findViewById(R.id.addTicketStatus);

                addT.setNegativeButton("Назад", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialogInterface, int i) {
                        dialogInterface.dismiss();
                    }
                });

                addT.setPositiveButton("Отправить", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialogInterface, int i) {

                        if (TextUtils.isEmpty(name.getText().toString())){
                            Snackbar.make(root, "Введите название!", Snackbar.LENGTH_SHORT).show();
                            return;
                        }
                        if (TextUtils.isEmpty(text.getText().toString())){
                            Snackbar.make(root, "Введите текст тикета!", Snackbar.LENGTH_SHORT).show();
                            return;
                        }
                        if (TextUtils.isEmpty(people.getText().toString())){
                            Snackbar.make(root, "Введите разработчиков!", Snackbar.LENGTH_SHORT).show();
                            return;
                        }
                        if (TextUtils.isEmpty(status.getText().toString())){
                            Snackbar.make(root, "Введите статус!", Snackbar.LENGTH_SHORT).show();
                            return;
                        }

                        ticketName = name.getText().toString();
                        ticketText = text.getText().toString();
                        ticketPeople = people.getText().toString();
                        ticketStatus = status.getText().toString();
                        ticketBoardName = spinner.getSelectedItem().toString();

                        Ticket ticket = new Ticket(ticketPeople, ticketText, ticketName);

                        TestGetTicket();

                        tickets.child(String.valueOf(myNumTicket)).setValue(ticket);


                    }
                });

                addT.show();

            }
        });


    }

    //тикеты получить из спинера
    private void GetTicketsFromSpinner() {

        spinner.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            public void onItemSelected(AdapterView<?> parent,
                                       View itemSelected, int selectedItemPosition, long selectedId) {
                GetTickets();
                Header.setText("Доска " + boardName);
            }

            public void onNothingSelected(AdapterView<?> parent) {
            }
        });
    }

    //получить доски
    private void GetBoards() {

        Intent intent = getActivity().getIntent();
        String userNameTestGet = intent.getStringExtra("login");

        dbBoards = FirebaseDatabase.getInstance().getReference("Users").child(userNameTestGet).child("Projects");
        dbBoards.addListenerForSingleValueEvent(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot snapshot) {
                final List<String> boardsList = new ArrayList<String>();

                for (DataSnapshot areaSnapshot : snapshot.getChildren()) {
                    String boardNameS = areaSnapshot.getValue(String.class);
                    boardsList.add(boardNameS);
            }
                ArrayAdapter<String> arrayAdapter = new ArrayAdapter<String>(getActivity(), android.R.layout.simple_spinner_item, boardsList);
                arrayAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
                spinner.setAdapter(arrayAdapter);
            }



            @Override
            public void onCancelled(@NonNull DatabaseError error) {

            }
        });


    }

    //получить тикеты
    private void GetTickets() {

        boardName = spinner.getSelectedItem().toString();

        database = FirebaseDatabase.getInstance().getReference("Projects").child(boardName).child("Kanban");
        recyclerView.setHasFixedSize(true);
        recyclerView.setLayoutManager(new LinearLayoutManager(getActivity()));


        list = new ArrayList<>();
        adapter = new MyAdapterForCalendar(getActivity(), list);
        recyclerView.setAdapter(adapter);

        database.addValueEventListener(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot snapshot) {
                for (DataSnapshot dataSnapshot : snapshot.getChildren()){

                        String ticketStatus = dataSnapshot.getKey();
                        DatabaseReference databaseStatus = database.child(ticketStatus);

                        databaseStatus.addValueEventListener(new ValueEventListener() {
                            @Override
                            public void onDataChange(@NonNull DataSnapshot snapshotT) {
                                for (DataSnapshot statusSnapshot : snapshotT.getChildren()) {
                                    Ticket ticket = statusSnapshot.getValue(Ticket.class);
                                    ticket.setStatus(ticketStatus);
                                    list.add(ticket);
                                }
                                adapter.notifyDataSetChanged();
                            }

                            @Override
                            public void onCancelled(@NonNull DatabaseError error) {

                            }
                        });

                }

            }

            @Override
            public void onCancelled(@NonNull DatabaseError error) {

            }
        });

    }

    //вспомогательная для добавления досок
    private void TestGet(){

        Intent intent = getActivity().getIntent();
        String userNameTestGet = intent.getStringExtra("login");

        itemsRef = FirebaseDatabase.getInstance().getReference("Users").child(userNameTestGet).child("Projects");

        itemsRef.addValueEventListener(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot snapshot) {
                for(DataSnapshot ds : snapshot.getChildren()) {
                    String increment = ds.getKey();

                    myNum = Integer.parseInt(increment);

                }
            }

            @Override
            public void onCancelled(@NonNull DatabaseError error) {

            }
        });

    }

    //вспомогательная для добавления тикетов
    private void TestGetTicket(){

        FirebaseDatabase db = FirebaseDatabase.getInstance();
        tickets = db.getReference("Projects").child(ticketBoardName).child("Kanban").child(ticketStatus);

        tickets.addValueEventListener(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot snapshot) {
                for(DataSnapshot ds : snapshot.getChildren()) {
                    String increment = ds.getKey();

                    myNumTicket = Integer.parseInt(increment) + 1;

                }
            }

            @Override
            public void onCancelled(@NonNull DatabaseError error) {

            }
        });

    }

    //добавление доски
    private void AddBoard(){

        addBoardBtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                AlertDialog.Builder addB = new AlertDialog.Builder(getActivity());
                addB.setTitle("Добавление новой доски");
                addB.setMessage("Введите название доски");

                LayoutInflater inflater = LayoutInflater.from(getActivity());
                View addB_window = inflater.inflate(R.layout.add_new_board, null);
                addB.setView(addB_window);

                final MaterialEditText name = addB_window.findViewById(R.id.addBoardName);

                addB.setNegativeButton("Назад", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialogInterface, int i) {
                        dialogInterface.dismiss();
                    }
                });
                addB.setPositiveButton("Отправить", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialogInterface, int i) {
                if (TextUtils.isEmpty(name.getText().toString())){
                    Snackbar.make(root, "Введите название!", Snackbar.LENGTH_SHORT).show();
                    return;
                }

                        String boardName = name.getText().toString();

                        TestGet();

                        //FirebaseDatabase db = FirebaseDatabase.getInstance();
                        DatabaseReference boardsNew = itemsRef.child(String.valueOf(myNum+1));
                        boardsNew.setValue(boardName);

                    }
                });

                addB.show();

            }
        });

    }


}