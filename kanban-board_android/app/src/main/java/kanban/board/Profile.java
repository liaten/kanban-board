package kanban.board;

import android.app.AlarmManager;
import android.app.PendingIntent;
import android.content.Context;
import android.content.Intent;
import android.os.Bundle;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.TextView;

import kanban.board.Models.UserNew;

import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseUser;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;


public class Profile extends Fragment {

    // the fragment initialization parameters, e.g. ARG_ITEM_NUMBER
    private static final String ARG_PARAM1 = "param1";
    private static final String ARG_PARAM2 = "param2";

    private String mParam1;
    private String mParam2;
    private FirebaseAuth auth;
    private TextView profileName, login, org, pass, fullName;
    private FirebaseDatabase db;
    private DatabaseReference users;


    private Button logOut;

    public Profile() {
        // Required empty public constructor
    }


    public static Profile newInstance(String param1, String param2) {
        Profile fragment = new Profile();
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
        ViewGroup viewGroup = (ViewGroup) inflater.inflate(R.layout.fragment_profile, container, false);


        auth = FirebaseAuth.getInstance();
        db = FirebaseDatabase.getInstance();
        users = db.getReference("Users");
        FirebaseUser cUser = auth.getCurrentUser();

        profileName = (TextView) viewGroup.findViewById(R.id.profile_name);
        login = (TextView) viewGroup.findViewById(R.id.loginProfile);
        org = (TextView) viewGroup.findViewById(R.id.orgProfile);
        pass = (TextView) viewGroup.findViewById(R.id.passProfile);
        fullName = (TextView) viewGroup.findViewById(R.id.nameProfile);
        logOut = (Button) viewGroup.findViewById(R.id.LogOut);


        GetCurUserInfo();
        LogOut();



        return viewGroup;
       // return inflater.inflate(R.layout.fragment_profile, container, false);
    }

    private void LogOut() {

        logOut.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                Intent mStartActivity = new Intent(getActivity(), Main.class);
                int mPendingIntentId = 123456;
                PendingIntent mPendingIntent = PendingIntent.getActivity(getActivity(), mPendingIntentId, mStartActivity, PendingIntent.FLAG_CANCEL_CURRENT);
                AlarmManager mgr = (AlarmManager)getActivity().getSystemService(Context.ALARM_SERVICE);
                mgr.set(AlarmManager.RTC, System.currentTimeMillis() + 100, mPendingIntent);
                System.exit(0);

            }
        });

    }

    private void GetCurUserInfo() {

        Intent intent = getActivity().getIntent();
        String usernamei = intent.getStringExtra("login");
        String userName = "Вы вошли как " + usernamei;
        profileName.setText(userName);

        DatabaseReference userDB;
        users.child(usernamei).addValueEventListener(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot snapshot) {

                UserNew user = snapshot.getValue(UserNew.class);

                login.setText(user.getUsername());
                org.setText(user.getOrganization());
                pass.setText(user.getPassword());
                fullName.setText(user.getFullName());
            }

            @Override
            public void onCancelled(@NonNull DatabaseError error) {

            }
        });

    }
}