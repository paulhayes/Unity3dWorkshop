#pragma strict
/*
 * CycleColour
 */
var startColour : Color;
var endColour : Color;
var cycleSpeed : float;

function Start () {
	renderer.material = new Material( renderer.sharedMaterial );
}

function Update () {
	var time = Mathf.PingPong( Time.time * cycleSpeed, 1f );
	renderer.material.color = Color.Lerp( startColour, endColour, time );
}
