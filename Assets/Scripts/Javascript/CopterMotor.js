#pragma strict
/*
 * CopterMotor.js
 */

public var thrust : float;
public var blade : Transform;
public var turnSpeed : float;

function Update(){
	blade.Rotate(0, turnSpeed * Time.deltaTime * thrust, 0);
}

function FixedUpdate () {
	var force : Vector3 = transform.up * thrust;
	collider.attachedRigidbody.AddForceAtPosition( force, transform.position );	
}


