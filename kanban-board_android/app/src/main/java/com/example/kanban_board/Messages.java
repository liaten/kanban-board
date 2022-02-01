package com.example.kanban_board;

import android.content.Intent;
import android.os.Bundle;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.ItemTouchHelper;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.LinearLayout;
import android.widget.Spinner;
import android.widget.TextView;

import com.example.kanban_board.Models.MessageAdapter;
import com.example.kanban_board.Models.MyAdapterForCalendar;
import com.example.kanban_board.Models.Ticket;
import com.example.kanban_board.Models.UserMessage;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;
import com.rengwuxian.materialedittext.MaterialEditText;

import java.util.ArrayList;
import java.util.List;

/**
 * A simple {@link Fragment} subclass.
 * Use the {@link Messages#newInstance} factory method to
 * create an instance of this fragment.
 */
public class Messages extends Fragment {

    // TODO: Rename parameter arguments, choose names that match
    // the fragment initialization parameters, e.g. ARG_ITEM_NUMBER
    private static final String ARG_PARAM1 = "param1";
    private static final String ARG_PARAM2 = "param2";

    // TODO: Rename and change types of parameters
    private String mParam1;
    private String mParam2;

    Spinner spinner;
    DatabaseReference dbBoards;
    RecyclerView recyclerView;
    DatabaseReference database;
    MessageAdapter adapter;
    ArrayList<UserMessage> list;

    String boardName = "";

    ImageButton sendButton;
    MaterialEditText messageText;

    TextView Header;

    Integer myNum = 0;

    Integer myNumTicket = 0;



    public Messages() {
        // Required empty public constructor
    }

    /**
     * Use this factory method to create a new instance of
     * this fragment using the provided parameters.
     *
     * @param param1 Parameter 1.
     * @param param2 Parameter 2.
     * @return A new instance of fragment Messages.
     */
    // TODO: Rename and change types and number of parameters
    public static Messages newInstance(String param1, String param2) {
        Messages fragment = new Messages();
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

        ViewGroup viewGroup = (ViewGroup) inflater.inflate(R.layout.fragment_messages, container, false);

        spinner = (Spinner) viewGroup.findViewById(R.id.spinnerBoardsMessages);
        recyclerView = (RecyclerView) viewGroup.findViewById(R.id.messageList);
        Header = (TextView) viewGroup.findViewById(R.id.headerMessages);
        sendButton = (ImageButton) viewGroup.findViewById(R.id.sendButton);
        messageText = (MaterialEditText) viewGroup.findViewById(R.id.sendMessageField);


        GetBoards();
        GetMessagesFromSpinner();
        SendMessages();

        return viewGroup;
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

    //получить сообщения
    private void GetMessages() {

        boardName = spinner.getSelectedItem().toString();

        database = FirebaseDatabase.getInstance().getReference("Projects").child(boardName).child("Chat");
        recyclerView.setHasFixedSize(true);
        recyclerView.setLayoutManager(new LinearLayoutManager(getActivity()));


        list = new ArrayList<>();
        adapter = new MessageAdapter(getActivity(), list);
        recyclerView.setAdapter(adapter);

        database.addValueEventListener(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot snapshot) {
                for (DataSnapshot dataSnapshot : snapshot.getChildren()){

                    String number = dataSnapshot.getKey();
                    DatabaseReference databaseMessage = database.child(number);

                    databaseMessage.addValueEventListener(new ValueEventListener() {
                        @Override
                        public void onDataChange(@NonNull DataSnapshot snapshotT) {
                            for (DataSnapshot messSnapshot : snapshotT.getChildren()) {

                                UserMessage messageN = new UserMessage();
                                String messageSender = messSnapshot.getKey();
                                messageN.setSender(messageSender);

                                String messageText = messSnapshot.getValue(String.class);
                                messageN.setText(messageText);
                                list.add(messageN);
                            }
                            adapter.notifyDataSetChanged();
                        }

                        @Override
                        public void onCancelled(@NonNull DatabaseError error) {

                        }
                    });


                }
                //adapter.notifyDataSetChanged();
            }

            @Override
            public void onCancelled(@NonNull DatabaseError error) {

            }
        });

    }

    //сообщения получить из спинера
    private void GetMessagesFromSpinner() {

        spinner.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            public void onItemSelected(AdapterView<?> parent,
                                       View itemSelected, int selectedItemPosition, long selectedId) {
                GetMessages();
                Header.setText("Доска " + boardName);
            }

            public void onNothingSelected(AdapterView<?> parent) {
            }
        });
    }

    private void SendMessages(){

        sendButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                String text = messageText.getText().toString();

                database = FirebaseDatabase.getInstance().getReference("Projects").child(boardName).child("Chat");

                database.addValueEventListener(new ValueEventListener() {
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
                Intent intent = getActivity().getIntent();
                String usernamei = intent.getStringExtra("login");

                DatabaseReference messageSend = database.child(String.valueOf(myNum+1)).child(usernamei);
                messageSend.setValue(text);
                messageText.setText("");


            }
        });

    }




}