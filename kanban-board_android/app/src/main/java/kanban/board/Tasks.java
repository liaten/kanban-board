package kanban.board;

import android.os.Bundle;

import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.GridLayoutManager;
import androidx.recyclerview.widget.ItemTouchHelper;
import androidx.recyclerview.widget.RecyclerView;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;

import kanban.board.Models.MyItemTouchHelperCallback;
import kanban.board.Models.MyRecyclerAdapter;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

import butterknife.ButterKnife;

/**
 * A simple {@link Fragment} subclass.
 * Use the {@link Tasks#newInstance} factory method to
 * create an instance of this fragment.
 */
public class Tasks extends Fragment {

    // TODO: Rename parameter arguments, choose names that match
    // the fragment initialization parameters, e.g. ARG_ITEM_NUMBER
    private static final String ARG_PARAM1 = "param1";
    private static final String ARG_PARAM2 = "param2";

    // TODO: Rename and change types of parameters
    private String mParam1;
    private String mParam2;


    //@BindView(R.id.addTicket)
    Button addTicket;

    //@BindView(R.id.recycler_view)
    RecyclerView recyclerView;

    public List<String> data = new ArrayList<>();

    ItemTouchHelper itemTouchHelper;


    public Tasks() {
        // Required empty public constructor
    }

    /**
     * Use this factory method to create a new instance of
     * this fragment using the provided parameters.
     *
     * @param param1 Parameter 1.
     * @param param2 Parameter 2.
     * @return A new instance of fragment Tasks.
     */
    // TODO: Rename and change types and number of parameters
    public static Tasks newInstance(String param1, String param2) {
        Tasks fragment = new Tasks();
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

     /*   addTicket.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                addItem();
            }
        }); */

        //init();
        //generateItem();


    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {

        ViewGroup viewGroup = (ViewGroup) inflater.inflate(R.layout.fragment_tasks, container, false);


        recyclerView = (RecyclerView) viewGroup.findViewById(R.id.recycler_view);
        //recyclerView = recyclerView.findViewById(R.id.recycler_view);

        addTicket = (Button) viewGroup.findViewById(R.id.addTicket);

        addTicket.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                addItem();
            }
        });


        init();
        generateItem();

        //viewGroup.addView(recyclerView);
        return viewGroup;
        //return inflater.inflate(R.layout.fragment_tasks, container, false);


    }

    private void addItem() {

        data.addAll(Arrays.asList(
                "Заголовок \nТекст тикета \nРазработчики"

        ));

        MyRecyclerAdapter adapter = new MyRecyclerAdapter(getActivity(), data, viewHolder -> {
            itemTouchHelper.startDrag(viewHolder);

        });
        recyclerView.setAdapter(adapter);
        ItemTouchHelper.Callback callback = new MyItemTouchHelperCallback(adapter);
        itemTouchHelper = new ItemTouchHelper(callback);
        itemTouchHelper.attachToRecyclerView(recyclerView);

    }

    private void init(){

        ButterKnife.bind(getActivity());
        recyclerView.setHasFixedSize(true);
        GridLayoutManager gridLayoutManager = new GridLayoutManager(getActivity(), 4);
        recyclerView.setLayoutManager(gridLayoutManager);


    }

    private void generateItem() {

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

        MyRecyclerAdapter adapter = new MyRecyclerAdapter(getActivity(), data, viewHolder -> {
            itemTouchHelper.startDrag(viewHolder);

        });
        recyclerView.setAdapter(adapter);
        ItemTouchHelper.Callback callback = new MyItemTouchHelperCallback(adapter);
        itemTouchHelper = new ItemTouchHelper(callback);
        itemTouchHelper.attachToRecyclerView(recyclerView);

    }




}