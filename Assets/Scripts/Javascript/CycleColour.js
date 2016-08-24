#pragma strict
/*
 * CycleColour
 */
var startColour : Color;
var endColour : Color;
var cycleSpeed : float;

function Start () {
	GetComponent.<Renderer>().material = new Material( GetComponent.<Renderer>().sharedMaterial );
}

function Update () {
	var time = Mathf.PingPong( Time.time * cycleSpeed, 1f );
	GetComponent.<Renderer>().material.color = Color.Lerp( startColour, endColour, time );
}
