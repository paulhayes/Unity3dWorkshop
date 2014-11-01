#pragma strict
/*
 * Pickup
 */
 
public var playerCamera : Camera;
public var maximumDistance : float;
public var holdingPosition : Transform;
public var pickUpKey : KeyCode;
public var useObjectKey : KeyCode;
public var pickUpRadius : float = 0.5;
public var pickupLayers : LayerMask;

private var holdingObject : Transform;


function Start () {
	
}

function Update () {
	if( Input.GetKeyDown(pickUpKey) ){
		Drop();
		Pickup();
	}	
	if( Input.GetKeyDown(useObjectKey) ){
		Use();
	}
}

function Pickup(){
	var playerPosition = playerCamera.transform.position;
	var playerDirection = playerCamera.transform.forward;	
	var hit : RaycastHit;
	
	if( Physics.SphereCast( playerPosition, pickUpRadius, playerDirection, hit, maximumDistance, pickupLayers ) ){
		if( hit.rigidbody ){
			holdingObject = hit.rigidbody.transform;
			holdingObject.rigidbody.isKinematic = true;
			holdingObject.rigidbody.detectCollisions = false;
			holdingObject.parent = holdingPosition;
			holdingObject.localPosition = Vector3.zero;
			holdingObject.localRotation = Quaternion.identity;	
		}
		
		
	}
}

function Drop(){
	if( holdingObject ){
		holdingObject.rigidbody.isKinematic = false;
		holdingObject.rigidbody.detectCollisions = true;
		holdingObject.parent = null;	
		holdingObject = null;	
	}
}

function Use(){
	if( holdingObject ){
		holdingObject.SendMessage("Use");
	}
}