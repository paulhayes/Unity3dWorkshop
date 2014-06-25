using UnityEngine;
using System.Collections;

public class SimpleFollow : MonoBehaviour 
{
	public Vector3 distance;
	public Transform target;
	
	void Update ()
	{
		transform.position = target.position + distance;
	}
}
