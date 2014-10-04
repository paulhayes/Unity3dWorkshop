using UnityEngine;
using System.Collections;

public class CycleColour : MonoBehaviour 
{
	public Color startColor;
	public Color endColor;
	public float speed;

	void Start () 
	{		
		renderer.material = new Material( renderer.sharedMaterial );
	}
	
	void Update ()
	{ 
		float t = Mathf.PingPong( Time.time * speed, 1f );
		renderer.material.color = Color.Lerp( startColor, endColor, t );
	}
}
