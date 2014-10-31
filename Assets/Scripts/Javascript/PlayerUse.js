#pragma strict

public var playerCamera : Camera;
public var maximumDistance : float;
public var useKey : KeyCode;
public var useCyclinerCastRadius : float = 0.1f;
public var layer : LayerMask;

function Update () {
	if( Input.GetKeyDown( useKey ) ){
		Use();
	}
}

function Use () {
	var playerPosition = playerCamera.transform.position;
	var playerDirection = playerCamera.transform.forward;
	var hit : RaycastHit;
	if( Physics.SphereCast( playerPosition, useCyclinerCastRadius, playerDirection, hit, maximumDistance, layer ) ){
		hit.collider.SendMessage("Use",SendMessageOptions.DontRequireReceiver);
	}
}