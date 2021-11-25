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
import android.widget.RelativeLayout;
import android.widget.TextView;
import android.widget.Toast;

import com.example.kanban_board.Models.User;
import com.google.android.gms.tasks.OnFailureListener;
import com.google.android.gms.tasks.OnSuccessListener;
import com.google.android.material.snackbar.Snackbar;
import com.google.firebase.auth.AuthResult;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseAuthException;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.rengwuxian.materialedittext.MaterialEditText;

public class MainActivity extends AppCompatActivity {

    Button btnSingIn, btnRegister;
    TextView view_f;

    FirebaseAuth auth;
    FirebaseDatabase db;
    DatabaseReference users;

    RelativeLayout root;

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
        view_f = findViewById(R.id.forgot_view);

        auth = FirebaseAuth.getInstance();
        db = FirebaseDatabase.getInstance();
        users = db.getReference("Users");

        root = findViewById(R.id.main_layout);

        log_f.setText("test@mail.ru");
        pas_f.setText("123456");

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

        auth.signInWithEmailAndPassword(login.getText().toString(), password.getText().toString()).addOnSuccessListener(new OnSuccessListener<AuthResult>() {
            @Override
            public void onSuccess(AuthResult authResult) {
                startActivity(new  Intent(MainActivity.this, Kanban_menu.class));
                finish();
            }
        }).addOnFailureListener(new OnFailureListener() {
            @Override
            public void onFailure(@NonNull Exception e) {
                Snackbar.make(root, "Неправильное имя пользователя или пароль" + e.getMessage(), Snackbar.LENGTH_SHORT).show();
                return;
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
                if (TextUtils.isEmpty(email.getText().toString())){
                    Snackbar.make(root, "Введите почту", Snackbar.LENGTH_SHORT).show();
                    return;
                }

                if (TextUtils.isEmpty(login.getText().toString())){
                    Snackbar.make(root, "Введите логин", Snackbar.LENGTH_SHORT).show();
                    return;
                }

                if (password.getText().toString().length() < 6){
                    Snackbar.make(root, "Введите пароль не менее 6 символов", Snackbar.LENGTH_SHORT).show();
                    return;
                }

                //Регистрация нового пользователя

                auth.createUserWithEmailAndPassword(email.getText().toString(), password.getText().toString()).addOnSuccessListener(new OnSuccessListener<AuthResult>() {
                    @Override
                    public void onSuccess(AuthResult authResult) {
                        User user = new User();
                        user.setEmail(email.getText().toString());
                        user.setLogin(login.getText().toString());
                        user.setPassword(password.getText().toString());

                        users.child(FirebaseAuth.getInstance().getCurrentUser().getUid()).setValue(user).addOnSuccessListener(new OnSuccessListener<Void>() {
                            @Override
                            public void onSuccess(Void unused) {
                                Snackbar.make(root, "Пользователь добавлен", Snackbar.LENGTH_SHORT).show();
                            }
                        }).addOnFailureListener(new OnFailureListener() {
                            @Override
                            public void onFailure(@NonNull Exception e) {
                                Snackbar.make(root, "Ошибка: " + e.getMessage(), Snackbar.LENGTH_SHORT).show();
                            }
                        });



                    }
                });

            }
        });

        reg.show();


    }



}