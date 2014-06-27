using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour 
{

	public Vector3 velocity;
	
	void Start () 
	{
	
	}
	
	void Update ()
	{
		transform.Rotate( velocity * Time.deltaTime );
	}
}
