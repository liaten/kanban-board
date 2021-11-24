package com.example.kanban_board;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;
import androidx.navigation.NavController;
import androidx.navigation.Navigation;
import androidx.navigation.fragment.NavHostFragment;
import androidx.navigation.ui.NavigationUI;
import androidx.recyclerview.widget.GridLayoutManager;
import androidx.recyclerview.widget.ItemTouchHelper;
import androidx.recyclerview.widget.RecyclerView;

import android.annotation.SuppressLint;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

import com.example.kanban_board.Models.MyItemTouchHelperCallback;
import com.example.kanban_board.Models.MyRecyclerAdapter;
import com.example.kanban_board.Models.OnStartDragListener;
import com.google.android.material.bottomnavigation.BottomNavigationView;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

import butterknife.BindView;
import butterknife.ButterKnife;
import butterknife.Optional;

public class Kanban_menu extends AppCompatActivity {

 /*   Button logout;

    @BindView(R.id.recycler_view)
    RecyclerView recyclerView;

    @BindView(R.id.addTicket)
    Button addTicket;

    ItemTouchHelper itemTouchHelper;

 */  // public List<String> data = new ArrayList<>();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_kanban_menu);


       // logout = findViewById(R.id.LogOut);


        BottomNavigationView bottomNavigationView = findViewById(R.id.bottomNavigationView);
        //NavController navController = Navigation.findNavController(this,  R.id.fragmentContainerView);

        NavHostFragment navHostFragment = (NavHostFragment) getSupportFragmentManager().findFragmentById(R.id.fragmentContainerView);
        NavController navController = navHostFragment.getNavController();
        NavigationUI.setupWithNavController(bottomNavigationView, navController);

        /*поменять
        addTicket.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                addItem();
            }
        });
*/

       // init();
       // generateItem();

    }

   /* private void addItem() {
        data.addAll(Arrays.asList(
                "Заголовок \nТекст тикета \nРазработчики"

        ));

        MyRecyclerAdapter adapter = new MyRecyclerAdapter(this, data, viewHolder -> {
            itemTouchHelper.startDrag(viewHolder);

        });
        recyclerView.setAdapter(adapter);
        ItemTouchHelper.Callback callback = new MyItemTouchHelperCallback(adapter);
        itemTouchHelper = new ItemTouchHelper(callback);
        itemTouchHelper.attachToRecyclerView(recyclerView);
    } */


 /*   private void generateItem() {

        //List<String> data = new ArrayList<>();
        data.addAll(Arrays.asList(
                "Заголовок \nТекст тикета \nРазработчики",
                "Заголовок \nТекст тикета \nРазработчики",
                "Заголовок \nТекст тикета \nРазработчики",
                "Заголовок \nТекст тикета \nРазработчики",
                "Заголовок \nТекст тикета \nРазработчики",
                "Заголовок \nТекст тикета \nРазработчики",
                "Заголовок \nТекст тикета \nРазработчики",
                "Заголовок \nТекст тикета \nРазработчики",
                "Заголовок \nТекст тикета \nРазработчики"


        ));

        MyRecyclerAdapter adapter = new MyRecyclerAdapter(this, data, viewHolder -> {
                itemTouchHelper.startDrag(viewHolder);

        });
        recyclerView.setAdapter(adapter);
        ItemTouchHelper.Callback callback = new MyItemTouchHelperCallback(adapter);
        itemTouchHelper = new ItemTouchHelper(callback);
        itemTouchHelper.attachToRecyclerView(recyclerView);

    }

    private void init(){
        setContentView(R.layout.fragment_tasks);
        ButterKnife.bind(this);
        recyclerView.setHasFixedSize(true);
        GridLayoutManager gridLayoutManager = new GridLayoutManager(this, 4);
        recyclerView.setLayoutManager(gridLayoutManager);

 }*/


}