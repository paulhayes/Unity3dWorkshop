using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class Debounce : MonoBehaviour {

    public UnityEvent OnActivateEvent;
    public float delay;

    float lastTime;

	public void Activate(){
        if( Time.time - lastTime < delay ){
            return;
        }

        OnActivateEvent.Invoke();

        lastTime = Time.time;

    }
}
