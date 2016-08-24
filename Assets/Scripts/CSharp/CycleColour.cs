using UnityEngine;
using System.Collections;

public class CycleColour : MonoBehaviour 
{
	public Color startColor;
	public Color endColor;
	public float speed;

	void Start () 
	{		
		GetComponent<Renderer>().material = new Material( GetComponent<Renderer>().sharedMaterial );
	}
	
	void Update ()
	{ 
		float t = Mathf.PingPong( Time.time * speed, 1f );
		GetComponent<Renderer>().material.color = Color.Lerp( startColor, endColor, t );
	}
}
