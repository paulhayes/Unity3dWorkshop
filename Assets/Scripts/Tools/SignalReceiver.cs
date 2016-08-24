using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using System.Linq;

public class SignalReceiver : MonoBehaviour {

    public int channel;
    public MessageEvent[] messageReceivers;

    private static HashSet<SignalReceiver> receivers = new HashSet<SignalReceiver>();
    private static SignalReceiver[] receiversArray = new SignalReceiver[1024];
    private static int receiverCount = 0;

	void Start () {
	
	}
	
	void Update () {
	
	}

    void Awake(){
        receivers.Add( this );
        receiverCount = receivers.Count;
        receivers.CopyTo( receiversArray );
    }

    void OnDestroy(){
        receivers.Remove( this );
        receiverCount = receivers.Count;
        receivers.CopyTo( receiversArray );
    }

    public void Receive(string message){
        for(int i=0;i<messageReceivers.Length;i++){
            if( message == messageReceivers[i].message ){
                messageReceivers[i].OnMessage.Invoke();
            }
        }
    }

    public static void Signal(int channel, string message, float distance, Vector3 emitterPosition){
        for(int i=receiverCount-1;i>=0;i--){            
            var receiver = receiversArray[i];
            if( receiver.channel == channel && Vector3.Distance(emitterPosition,receiver.transform.position)<=distance ){
                receiver.Receive(message);
            }
        }
    }
}

[System.Serializable]
public class MessageEvent {
    public string message;
    public UnityEvent OnMessage;
}
