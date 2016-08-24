using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class OnVisible : MonoBehaviour {

	public UnityEvent OnVisibleEvent;
    public UnityEvent OnInvisibleEvent;

    void OnBecameVisible(){
        OnVisibleEvent.Invoke();
    }

    void OnBecameInvisible(){
        OnInvisibleEvent.Invoke();
    }
}
