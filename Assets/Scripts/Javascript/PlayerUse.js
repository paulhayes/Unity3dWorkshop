#pragma strict

public var playerCamera : Camera;
public var maximumDistance : float;
public var useKey : KeyCode;
public var useCyclinerCastRadius : float = 0.5f;

function Update () {
	if( Input.GetKeyDown( useKey ) ){
		Use();
	}
}

function Use () {
	var playerPosition = playerCamera.transform.position + playerCamera.transform.forward;
	var playerDirection = playerCamera.transform.forward;
	var hit : RaycastHit;
	if( Physics.SphereCast( playerPosition, useCyclinerCastRadius, playerDirection, hit, maximumDistance ) ){
		hit.collider.SendMessage("Use",SendMessageOptions.DontRequireReceiver);
	}
}