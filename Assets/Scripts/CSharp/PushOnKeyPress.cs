using UnityEngine;
using System.Collections;

public class PushOnKeyPress : MonoBehaviour 
{
	public string inputAxis;
	public Vector3 force;
	public Vector3 torque;
    Rigidbody body;

    void Awake(){
        body = GetComponent<Rigidbody>();
    }

	void FixedUpdate ()
	{
        float axis = Input.GetAxis(inputAxis);
        body.AddForce( axis*force, ForceMode.Impulse );
        body.AddTorque( axis*torque, ForceMode.Impulse );
	}
}
