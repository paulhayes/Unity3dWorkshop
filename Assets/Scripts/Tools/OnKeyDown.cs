using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class OnKeyDown : MonoBehaviour {

	public KeyCode key;
    public UnityEvent OnKeyDownEvent;

    void Update(){
        if( Input.GetKeyDown( key ) ){
            OnKeyDownEvent.Invoke();
        }
    }
}
