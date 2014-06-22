using UnityEngine;
using System.Collections;

public class FollowMouse : MonoBehaviour 
{
	public bool followX;
	public bool followY;
	
	void Update ()
	{
		float depth = Camera.main.transform.InverseTransformPoint( transform.position ).z;
		Vector3 mouse = new Vector3( Input.mousePosition.x, Input.mousePosition.y, depth );
		Vector3 worldPosition = Camera.main.ScreenToWorldPoint( mouse );
		if( ! followX ){
			worldPosition.x = transform.position.x;
		}
		if( ! followY ){
			worldPosition.y = transform.position.y;
		}
		
		if( rigidbody ){
			rigidbody.position = worldPosition;
		}
		else {
			transform.position = worldPosition;			
		}
		
	}
}
