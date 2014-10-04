#pragma strict
/*
 * BiggerOnClick.js
 * Makes an object bigger when you click it
 */

public var howMuchBigger : float;
	
protected var scale : Vector3;

function Start () 
{
	scale = transform.localScale;
}

function OnMouseDown()
{
	transform.localScale = scale * howMuchBigger;
}

function OnMouseUp()
{
	transform.localScale = scale;	
}