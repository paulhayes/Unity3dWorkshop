#pragma strict
/*
 * Wand.js
 */

var radius = 5.0;
var power = 10.0;
var explosionEffect : GameObject;

function Use(){
	var hit : RaycastHit;
	var pos = transform.position + transform.forward;
	
	if( Physics.Raycast( pos, transform.forward, hit, 100f ) ){
		Explosion( hit.point );
	}
}


function Explosion(explosionPos:Vector3){
	
	// Applies an explosion force to all nearby rigidbodies
	var colliders : Collider[] = Physics.OverlapSphere (explosionPos, radius);
	
	Instantiate(explosionEffect,explosionPos,Quaternion.identity);
	
	for (var hit : Collider in colliders) {
		Debug.Log("hit:"+hit.collider.name);
		if (hit && hit.rigidbody)
			hit.rigidbody.AddExplosionForce(power, explosionPos, radius, 3.0);
	}
}