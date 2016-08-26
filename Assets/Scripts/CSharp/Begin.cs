using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class Begin : MonoBehaviour {

    public UnityEvent OnBeginEvent;

	void Start () {
	    OnBeginEvent.Invoke();
	}
	

}
