package com.yiyang.yang.hometask;

import android.content.Intent;
import android.support.v7.app.ActionBarActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.EditText;


public class MainActivity extends ActionBarActivity {

    public static String EXTRA_MESSAGE ="com.yiyang.yang.hometask.message";
    public static String EXTRA_MESSAGE2 ="com.yiyang.yang.hometask.message2";
    public static String EXTRA_MESSAGE3 ="com.yiyang.yang.hometask.message3";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }


    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }
    public void send(View view){
         Intent intent = new Intent(this,MainActivity2.class);
        EditText name = (EditText) findViewById(R.id.name);
        String text = name.getText().toString();
        intent.putExtra( EXTRA_MESSAGE,text);

        EditText like = (EditText) findViewById(R.id.like);
        String text2 = name.getText().toString();
        intent.putExtra( EXTRA_MESSAGE2,text2);

        EditText dislike = (EditText) findViewById(R.id.dislike);
        String text3 = name.getText().toString();
        intent.putExtra( EXTRA_MESSAGE3,text3);

        startActivity(intent);


    }
}
