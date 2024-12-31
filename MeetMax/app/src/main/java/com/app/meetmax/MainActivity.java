package com.app.meetmax;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.microsoft.signalr.HubConnection;
import com.microsoft.signalr.HubConnectionBuilder;
import com.microsoft.signalr.HubException;

import org.jitsi.meet.sdk.JitsiMeet;
import org.jitsi.meet.sdk.JitsiMeetActivity;
import org.jitsi.meet.sdk.JitsiMeetConferenceOptions;

import java.net.MalformedURLException;
import java.net.URL;

public class MainActivity extends AppCompatActivity {

    EditText codeBox;
    Button button,share;
    private HubConnection hubConnection;
    private String roomName = "SigmaJitsiRoom";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        codeBox= findViewById(R.id.codeBox);
        button= findViewById(R.id.button);
        share= findViewById(R.id.share);

        URL serverUrl;

//        try{
//            serverUrl = new URL("https://meet.jit.si");
//            JitsiMeetConferenceOptions defaultOption= new JitsiMeetConferenceOptions.Builder()
//                    .setServerURL(serverUrl)
//                    .build();
//            JitsiMeet.setDefaultConferenceOptions(defaultOption);
//
//        }catch(MalformedURLException e){
//            e.printStackTrace();
//        }


        button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
//                String text= codeBox.getText().toString();
                conneectToServer("");
//                if(text.length()>0){

//                    JitsiMeetConferenceOptions options= new JitsiMeetConferenceOptions.Builder()
//                            .setRoom(text)
////                            .setFeatureFlag("invite.enabled",false)
//                            .setFeatureFlag("prejoinpage.enabled", false)
//                            .build();
//                    JitsiMeetActivity.launch(MainActivity.this,options);

                    URL serverURL = null;
                    try {
                        serverURL = new URL("https://meet.jit.si");
                        JitsiMeetConferenceOptions options = new JitsiMeetConferenceOptions.Builder()
                                .setServerURL(serverURL)
                                .setRoom(roomName)
                                .build();
                        JitsiMeetActivity.launch(MainActivity.this, options);
                    } catch (MalformedURLException e) {
                        throw new RuntimeException(e);
                    }

                }
//            }
        });


        share.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent shareIntent= new Intent();
                shareIntent.setAction(Intent.ACTION_SEND);
                shareIntent.putExtra(Intent.EXTRA_TEXT,"Enter the room code to join the meeting: "+ codeBox.getText().toString());
                shareIntent.setType("text/plain");
                startActivity(shareIntent);
            }
        });

    }

    public void conneectToServer(String txt){

        try{
            // Establish a connection to the SignalR hub
            hubConnection = HubConnectionBuilder.create("https://sigmademo.grahaak.com/VideoCallHub")
                    .build();

            // Start the SignalR connection
            hubConnection.start().blockingAwait();

            // Example of initiating a video call
            String adminId = "anuj1902"; // Replace with the actual admin identifier
            String jitsiRoomUrl = "https://meet.jit.si/"+txt; // Replace with your Jitsi room URL

            // Notify the server about the video call initiation
            hubConnection.send("NotifyIncomingCall", hubConnection.getConnectionId(), roomName);
        }catch (Exception e){
            e.getMessage();
            Toast.makeText(getApplicationContext(),"Error!! "+e.getMessage(),Toast.LENGTH_SHORT).show();

        }

    }
}