#pragma strict
/*
 * Wand
 */
class WandEvent extends UnityEngine.Events.UnityEvent.<Vector3>{}

var maxDistance : float = 10.0;
var OnUseWandEvent : WandEvent;


function Use(){
	var hit : RaycastHit;
	var pos = transform.position + transform.forward;
	
	if( Physics.SphereCast( pos, 0.5, transform.forward, hit, maxDistance ) ){
		Trigger( hit.point );
	}
	else {
		Debug.Log("Didn't hit anything, triggering at max distance");
		Debug.Log( transform.position + maxDistance * transform.forward );
		Trigger( transform.position + maxDistance * transform.forward );
	}
}

function Trigger(pos:Vector3){
	OnUseWandEvent.Invoke(pos);
}

