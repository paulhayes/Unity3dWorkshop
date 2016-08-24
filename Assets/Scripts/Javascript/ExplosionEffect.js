#pragma strict
/*
 * ExplosionWand
 */

var radius = 5.0;
var power = 10.0;
var explosionEffect : GameObject;

public function Explosion(explosionPos:Vector3){
	
	// Applies an explosion force to all nearby rigidbodies
	var colliders : Collider[] = Physics.OverlapSphere (explosionPos, radius);
	
	Instantiate(explosionEffect,explosionPos,Quaternion.identity);
	
	for (var hit : Collider in colliders) {
		Debug.Log("hit:"+hit.GetComponent.<Collider>().name);
		if (hit && hit.GetComponent.<Rigidbody>())
			hit.GetComponent.<Rigidbody>().AddExplosionForce(power, explosionPos, radius, 3.0);
	}
}