#pragma strict
/*
 * Wand.js
 */

var maxDistance : float = 10.0;
var triggerName : String;

function Use(){
	var hit : RaycastHit;
	var pos = transform.position + transform.forward;
	
	if( Physics.SphereCast( pos, 0.5, transform.forward, hit, maxDistance ) ){
		Trigger( hit.point );
	}
	else {
		Trigger( transform.position + maxDistance * transform.forward );
	}
}

function Trigger(pos:Vector3){
	SendMessage( triggerName, pos );
}