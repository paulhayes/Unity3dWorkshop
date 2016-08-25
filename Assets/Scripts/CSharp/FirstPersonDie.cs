using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class FirstPersonDie : MonoBehaviour {

    public UnityEvent OnDieEvent;

    Rigidbody body;

    void Awake(){
        body = GetComponent<Rigidbody>();
    }


    public void Die(){
        body.constraints = RigidbodyConstraints.None;
        body.AddRelativeTorque( Random.onUnitSphere );
        OnDieEvent.Invoke();
    }
}
