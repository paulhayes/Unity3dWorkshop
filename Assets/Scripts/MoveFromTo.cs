using UnityEngine;
using System.Collections;

public class MoveFromTo : MonoBehaviour 
{
	public Transform from;
	public Transform to;
	[Range(0,10)]
	public float speed;

	void Update ()
	{
		float time = Mathf.PingPong( Time.time * speed, 1f );
		transform.position = Vector3.Lerp( from.position, to.position, time );
		
	}
}
