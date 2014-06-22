using UnityEngine;
using System.Collections;

public class PushOnCollision : MonoBehaviour 
{
	public float forceStrength;
	
	void Start () 
	{
	
	}
	
	void Update ()
	{
	
	}
	
	void OnCollisionEnter(Collision collision){
		Vector3.
		Vector3 direction = ( collision.transform.position - transform.position ).normalized;
		collision.collider.attachedRigidbody.AddForce( forceStrength * direction, ForceMode.Impulse ); 
	}
}
