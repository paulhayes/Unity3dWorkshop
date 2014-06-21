using UnityEngine;
using System.Collections;

public class MakeBiggerOnClick : MonoBehaviour 
{
	public float howMuchBigger;
	
	protected Vector3 scale;
	
	void Start () 
	{
		scale = transform.localScale;
	}
	
	void OnMouseDown()
	{
		transform.localScale = scale * howMuchBigger;
	}
	
	void OnMouseUp()
	{
		transform.localScale = scale;	
	}
}
