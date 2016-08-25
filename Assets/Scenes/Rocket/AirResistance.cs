using UnityEngine;
using System.Collections;

public class AirResistance : MonoBehaviour {

    public Vector3 resistanceDirection;
    public float strength;
    Rigidbody body;
	void Awake () {
	    body = GetComponent<Rigidbody>();
	}   
	
	// Update is called once per frame
	void FixedUpdate () {
        var dir  = transform.TransformDirection( resistanceDirection.normalized );
        var drag = Vector3.Dot( body.velocity, dir );

        body.AddForce( strength*drag*-1f*dir, ForceMode.Force );
	}

    void OnDrawGizmosSelected(){
        Gizmos.color = Color.red;
        var dir  = transform.TransformDirection( resistanceDirection.normalized );
        if( Application.isPlaying ) {
            var drag = Vector3.Dot( body.velocity, dir );

            Gizmos.DrawRay( transform.position, strength*drag*-1f*dir );

        } else {
            Gizmos.DrawRay( transform.position, dir );

        }
    }
}
