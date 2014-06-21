using UnityEngine;
using System.Collections;

public class MoveInACircle : MonoBehaviour 
{
	public float xSpeed;
	public float ySpeed;
	public float xDistance;
	public float yDistance;
	
	void Update ()
	{	
		float x = xDistance * Mathf.Cos(xSpeed * Time.time * Mathf.PI);
		float y = yDistance * Mathf.Sin(ySpeed * Time.time * Mathf.PI);
		transform.position = new Vector3( x, y, 0f );
	}
}
