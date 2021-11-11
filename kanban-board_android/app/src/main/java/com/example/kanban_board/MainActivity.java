package com.example.kanban_board;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.DialogInterface;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import com.rengwuxian.materialedittext.MaterialEditText;

public class MainActivity extends AppCompatActivity {

    Button btnSingIn, btnRegister;
    TextView view_f;




    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        btnSingIn = findViewById(R.id.SingIn);
        btnRegister = findViewById(R.id.Register);
        view_f = findViewById(R.id.forgot_view);

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

    }

    private void showForgotWindow() {
        AlertDialog.Builder forgot = new AlertDialog.Builder(this);
        forgot.setTitle("Восстановление учетной записи");
        forgot.setMessage("Введите адрес почты, используемый при регистрации:");

        LayoutInflater inflater = LayoutInflater.from(this);
        View forgot_window = inflater.inflate(R.layout.forgot_w, null);
        forgot.setView(forgot_window);

        MaterialEditText email = forgot_window.findViewById(R.id.email_field_f);

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


    private void showRegisterWindow() {

        AlertDialog.Builder reg = new AlertDialog.Builder(this);
        reg.setTitle("Регистрация");
        reg.setMessage("Заполните все поля");

        LayoutInflater inflater = LayoutInflater.from(this);
        View reg_window = inflater.inflate(R.layout.reg_w, null);
        reg.setView(reg_window);

        MaterialEditText email = reg_window.findViewById(R.id.email_field);
        MaterialEditText login = reg_window.findViewById(R.id.login_field);
        MaterialEditText password = reg_window.findViewById(R.id.password_field);

        reg.setNegativeButton("Назад", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialogInterface, int i) {
                dialogInterface.dismiss();
            }
        });

        reg.setPositiveButton("Отправить", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialogInterface, int i) {

            }
        });

        reg.show();


    }



}