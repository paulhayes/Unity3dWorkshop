#pragma strict
/*
 * PlaySoundOnClick.js
 */
function OnMouseDown()
{
	GetComponent.<AudioSource>().Play();
}