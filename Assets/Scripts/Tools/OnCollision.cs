using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class OnCollision : MonoBehaviour {

    public UnityEvent OnCollisionEvent;
    public enum Conditions {
        Enter,
        Exit,
        Both
    }
    public string targetTag = "Player";
    public Conditions condition = Conditions.Enter;
       
    void OnCollisionEnter(Collision col){
        if( !col.collider.CompareTag(targetTag) ){
            return;
        }
        if( condition == Conditions.Enter || condition == Conditions.Both ){
            OnCollisionEvent.Invoke();
        }
    }

    void OnCollisionExit(Collision col){
        if( !col.collider.CompareTag(targetTag) ){
            return;
        }
        if( condition == Conditions.Exit || condition == Conditions.Both ){
            OnCollisionEvent.Invoke();
        }
    }
}
