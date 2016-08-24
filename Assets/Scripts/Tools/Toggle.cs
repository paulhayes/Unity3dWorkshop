using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class Toggle : MonoBehaviour {

	public bool isOn;
    public UnityEvent OnEvent;
    public UnityEvent OffEvent;

    public void ActivateToggle(){
        isOn = !isOn;
        if( isOn ){
            OnEvent.Invoke();
        }
        else {
            OffEvent.Invoke();
        }
    }
}
