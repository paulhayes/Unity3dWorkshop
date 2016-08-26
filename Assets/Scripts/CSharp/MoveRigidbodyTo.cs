using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class MoveRigidbodyTo : MonoBehaviour {

    public float speed;

    public UnityEvent OnMoveComplete;

    Rigidbody body;
    Vector3 destination;
    bool moving;


    public void MoveRigidBodyTo(Transform dest){
        destination = dest.position;
        moving = true;
    }

    void Awake(){
        
        body = GetComponent<Rigidbody>();
    }

    void FixedUpdate(){
        if( !moving ){
            return;
        }
        body.MovePosition( Vector3.MoveTowards( body.position, destination, speed * Time.fixedDeltaTime ) );
        if( body.position == destination ){
            moving = false;
            OnMoveComplete.Invoke();
        }
       
    }

}
