using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class Counter : MonoBehaviour {
    public int counter = 0;
    public int goalAmount = 1;
    public UnityEvent OnGoalEvent;

    bool changed = 0;

	void Increment(){
        counter++;
        changed = true;
    }

    void Decremement(){
        counter--;
        changed = true;
    }

    void Update(){
        if( changed ){
            if( counter == goalAmount ){
                OnGoalEvent.Invoke();
            }
            changed = false;
        }
        
    }
}
