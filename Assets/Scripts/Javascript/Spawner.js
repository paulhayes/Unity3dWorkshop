﻿#pragma strict

var prefab : GameObject;

function Spawn (position:Vector3) {
	Instantiate( prefab, position, Quaternion.identity );
}
