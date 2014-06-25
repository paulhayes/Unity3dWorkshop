using UnityEngine;
using System.Collections;

public class PushOnKeyPress : MonoBehaviour 
{
	public KeyCode keyCode;
	public Vector3 force;
	public Vector3 torque;
	
	void Start () 
	{
	
	}
	
	void Update ()
	{
		if( Input.GetKey( keyCode ) ){
			
			rigidbody.AddForce( force, ForceMode.Impulse );
			rigidbody.AddTorque( torque, ForceMode.Impulse );
		}
	}
}
