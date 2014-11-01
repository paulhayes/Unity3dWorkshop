#pragma strict

/*
 * LightSwitch
 */


var spotLight : Light;

function Start () {

}

function Use () {
	spotLight.enabled = ! spotLight.enabled;
}