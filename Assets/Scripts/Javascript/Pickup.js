#pragma strict
/*
 * Pickup.js
 */
 
public var playerCamera : Camera;
public var maximumDistance : float;
public var holdingPosition : Transform;
public var holdingObject : Transform;
public var pickUpKey : KeyCode;
public var useObjectKey : KeyCode;

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
	var playerPosition = playerCamera.transform.position + playerCamera.transform.forward;
	var playerDirection = playerCamera.transform.forward;
	var hit : RaycastHit;
	if( Physics.Raycast( playerPosition, playerDirection, hit, maximumDistance ) ){
		if( hit.rigidbody ){
			
			hit.rigidbody.isKinematic = true;
			holdingObject = hit.rigidbody.transform;
			holdingObject.parent = holdingPosition;
			holdingObject.localPosition = Vector3.zero;
			holdingObject.localRotation = Quaternion.identity;		
		}
		
		
	}
}

function Drop(){
	if( holdingObject ){
		holdingObject.rigidbody.isKinematic = false;
		holdingObject.parent = null;	
		holdingObject = null;	
	}
}


function Use(){
	if( holdingObject ){
		holdingObject.SendMessage("Use");
	}
}