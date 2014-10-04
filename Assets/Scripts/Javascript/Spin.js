#pragma strict
/*
 * Spin.js
 */
 
public var velocity : Vector3; 

function Update ()
{
	transform.Rotate( velocity * Time.deltaTime );
}