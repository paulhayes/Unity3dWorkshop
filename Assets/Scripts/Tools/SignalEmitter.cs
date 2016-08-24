using UnityEngine;
using System.Collections;

public class SignalEmitter : MonoBehaviour {

    public int channel = 0;
    public string message = "";
    public float distance = 1000;

    public void Emit(){
        SignalReceiver.Signal( channel, message, distance, transform.position );
    }

    public void Emit(string message){
        SignalReceiver.Signal( channel, message, distance, transform.position );
    }
}
