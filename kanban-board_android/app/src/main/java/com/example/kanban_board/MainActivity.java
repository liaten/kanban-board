package com.example.kanban_board;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.text.Layout;
import android.text.TextUtils;
import android.view.LayoutInflater;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.CompoundButton;
import android.widget.LinearLayout;
import android.widget.RelativeLayout;
import android.widget.TextView;
import android.widget.Toast;

import com.example.kanban_board.Models.User;
import com.example.kanban_board.Models.UserNew;
import com.google.android.gms.tasks.OnFailureListener;
import com.google.android.gms.tasks.OnSuccessListener;
import com.google.android.material.snackbar.Snackbar;
import com.google.firebase.auth.AuthResult;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseAuthException;
import com.google.firebase.auth.FirebaseUser;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.Query;
import com.google.firebase.database.ValueEventListener;
import com.rengwuxian.materialedittext.MaterialEditText;

public class MainActivity extends AppCompatActivity {

    Button btnSingIn, btnRegister, btnSingInAuth, btnlogOut;
    TextView view_f, pNameAuth;

    FirebaseAuth auth;
    FirebaseDatabase db;
    DatabaseReference users;
    DatabaseReference newUser;

    RelativeLayout root;
    LinearLayout enterlog, btns, frgt;

    MaterialEditText log_f;
    MaterialEditText pas_f;



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        log_f = findViewById(R.id.login_field_e);
        pas_f = findViewById(R.id.password_field_e);

        btnSingIn = findViewById(R.id.SingIn);
        btnRegister = findViewById(R.id.Register);
        btnSingInAuth = findViewById(R.id.SingInAuth);
        btnlogOut = findViewById(R.id.SingOut);

        view_f = findViewById(R.id.forgot_view);
        pNameAuth = findViewById(R.id.profile_name_auth);

        auth = FirebaseAuth.getInstance();
        db = FirebaseDatabase.getInstance();
        users = db.getReference("Users");

        root = findViewById(R.id.main_layout);

        enterlog = findViewById(R.id.enter_login);
        btns = findViewById(R.id.buttons_e);
        frgt = findViewById(R.id.check_box_l);

        log_f.setText("dsyt17");
        pas_f.setText("pass");

        //Кнопки

        btnRegister.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                showRegisterWindow();
            }
        });

        view_f.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                showForgotWindow();
            }
        });

        btnSingIn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                showMainWindow();
            }
        });

        btnSingInAuth.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startActivity(new  Intent(MainActivity.this, Kanban_menu.class));
            }
        });

        btnlogOut.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                signOut();
            }
        });



    }

    private void signOut() {

        FirebaseAuth.getInstance().signOut();

        btnSingInAuth.setVisibility(View.GONE);
        pNameAuth.setVisibility(View.GONE);
        btnlogOut.setVisibility(View.GONE);

        enterlog.setVisibility(View.VISIBLE);
        btns.setVisibility(View.VISIBLE);
        frgt.setVisibility(View.VISIBLE);
    }

    @Override
    protected void onStart(){
        super.onStart();
        FirebaseUser cUser = auth.getCurrentUser();
        if(cUser != null){
            btnSingInAuth.setVisibility(View.VISIBLE);
            pNameAuth.setVisibility(View.VISIBLE);
            btnlogOut.setVisibility(View.VISIBLE);

            enterlog.setVisibility(View.GONE);
            btns.setVisibility(View.GONE);
            frgt.setVisibility(View.GONE);

            String userName = "Вы вошли как " + cUser.getEmail();
            pNameAuth.setText(userName);
        }

        else {
            btnSingInAuth.setVisibility(View.GONE);
            pNameAuth.setVisibility(View.GONE);
            btnlogOut.setVisibility(View.GONE);

            enterlog.setVisibility(View.VISIBLE);
            btns.setVisibility(View.VISIBLE);
            frgt.setVisibility(View.VISIBLE);

        }


    }


    //Войти

    private void showMainWindow() {

        LayoutInflater inflater = LayoutInflater.from(this);
        View enter_window = inflater.inflate(R.layout.activity_main, null);

        final MaterialEditText login = findViewById(R.id.login_field_e);
        final MaterialEditText password = findViewById(R.id.password_field_e);


        if (TextUtils.isEmpty(login.getText().toString())){
            Snackbar.make(root, "Введите логин", Snackbar.LENGTH_SHORT).show();
            return;
        }

        if (TextUtils.isEmpty(password.getText().toString())){
            Snackbar.make(root, "Введите пароль", Snackbar.LENGTH_SHORT).show();
            return;
        }


        String login_e = login.getText().toString().trim();
        String password_e = password.getText().toString().trim();

        DatabaseReference reference_login = FirebaseDatabase.getInstance().getReference("Users");

        Query checkUser = reference_login.orderByChild("login").equalTo(login_e);


        checkUser.addListenerForSingleValueEvent(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot snapshot) {

                if(snapshot.exists()){


                    String passFromDB = snapshot.child(login_e).child("password").getValue(String.class);

                    if (passFromDB.equals(password_e)){

                        String accName = snapshot.child(login_e).child("login").getValue(String.class);
                        String accPass = snapshot.child(login_e).child("password").getValue(String.class);

                        Intent intent = new Intent(MainActivity.this, Kanban_menu.class);
                        intent.putExtra("login", accName);
                        intent.putExtra("password", accPass);

                        startActivity(intent);


                    }
                    else {
                        Snackbar.make(root, "Неправильное пароль", Snackbar.LENGTH_SHORT).show();
                    }

                }
                else {
                    Snackbar.make(root, "Неправильный логин", Snackbar.LENGTH_SHORT).show();
                }



            }

            @Override
            public void onCancelled(@NonNull DatabaseError error) {

            }
        });


    }

    //Забыл пароль (доделать)

    private void showForgotWindow() {
        AlertDialog.Builder forgot = new AlertDialog.Builder(this);
        forgot.setTitle("Восстановление учетной записи");
        forgot.setMessage("Введите адрес почты, используемый при регистрации:");

        LayoutInflater inflater = LayoutInflater.from(this);
        View forgot_window = inflater.inflate(R.layout.forgot_w, null);
        forgot.setView(forgot_window);

        final MaterialEditText email = forgot_window.findViewById(R.id.email_field_f);

        forgot.setNegativeButton("Назад", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialogInterface, int i) {
                dialogInterface.dismiss();
            }
        });

        forgot.setPositiveButton("Отправить", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialogInterface, int i) {

            }
        });

        forgot.show();
    }


    //Регистрация

    private void showRegisterWindow() {

        AlertDialog.Builder reg = new AlertDialog.Builder(this);
        reg.setTitle("Регистрация");
        reg.setMessage("Заполните все поля");

        LayoutInflater inflater = LayoutInflater.from(this);
        View reg_window = inflater.inflate(R.layout.reg_w, null);
        reg.setView(reg_window);

        final MaterialEditText email = reg_window.findViewById(R.id.email_field);
        final MaterialEditText login = reg_window.findViewById(R.id.login_field);
        final MaterialEditText password = reg_window.findViewById(R.id.password_field);

        reg.setNegativeButton("Назад", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialogInterface, int i) {
                dialogInterface.dismiss();
            }
        });

        reg.setPositiveButton("Отправить", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialogInterface, int i) {


                    if (TextUtils.isEmpty(login.getText().toString())){
                    Snackbar.make(root, "Введите логин", Snackbar.LENGTH_SHORT).show();
                    return;
                }

                if (password.getText().toString().length() < 4){
                    Snackbar.make(root, "Введите пароль не менее 4 символов", Snackbar.LENGTH_SHORT).show();
                    return;
                }

                String login_u = login.getText().toString();
                String password_u = password.getText().toString();
                String email_u = email.getText().toString();

                UserNew user = new UserNew("User", password_u, login_u, email_u);


                users.child(login_u).setValue(user);

                users.child(login_u).child("Projects").child("1").setValue("info");


            }
       });

                reg.show();

    }



}