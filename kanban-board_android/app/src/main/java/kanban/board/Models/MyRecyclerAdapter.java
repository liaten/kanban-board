package kanban.board.Models;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.MotionEvent;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.cardview.widget.CardView;
import androidx.fragment.app.FragmentActivity;
import androidx.recyclerview.widget.RecyclerView;

import kanban.board.R;

import java.util.Collections;
import java.util.List;

import butterknife.BindView;
import butterknife.ButterKnife;
import butterknife.Unbinder;

public class MyRecyclerAdapter extends RecyclerView.Adapter<MyRecyclerAdapter.MyViewHolder>
implements ItemTouchHelperAdapter {


    Context context;
    List<String> stringList;
    OnStartDragListener listener;

    public MyRecyclerAdapter(FragmentActivity context, List<String> stringList, OnStartDragListener listener) {
        this.context = context;
        this.stringList = stringList;
        this.listener = listener;
    }

    @NonNull
    @Override
    public MyViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        return new MyViewHolder(LayoutInflater.from(context).inflate(R.layout.layout_card_item,parent,false));
    }

    @Override
    public void onBindViewHolder(@NonNull MyViewHolder holder, int position) {
        holder.txt_number.setText(new StringBuilder().append(position+1));
        holder.txt_title.setText(stringList.get(position));
        holder.task_item.setOnTouchListener((View.OnTouchListener) (view, motionEvent) -> {
            final int action = motionEvent.getAction();
            if (action == MotionEvent.ACTION_DOWN)
                listener.onStartDrag(holder);
            return false;
        });
    }

    @Override
    public int getItemCount() {
        return stringList.size();
    }

    @Override
    public boolean onItemMove(int fromPosition, int toPosition) {
        Collections.swap(stringList, fromPosition, toPosition);
        notifyItemMoved(fromPosition, toPosition);
        return true;
    }

    @Override
    public void onItemDismiss(int position) {
        stringList.remove(position);
        notifyItemRemoved(position);
    }

    public class MyViewHolder extends RecyclerView.ViewHolder {

        @BindView(R.id.txt_title)
        TextView txt_title;
        @BindView(R.id.txt_number)
        TextView txt_number;
        @BindView(R.id.task_item)
        CardView task_item;

        Unbinder unbinder;

        public MyViewHolder(@NonNull View itemView) {
            super(itemView);

            unbinder = ButterKnife.bind(this, itemView);
        }
    }
}
