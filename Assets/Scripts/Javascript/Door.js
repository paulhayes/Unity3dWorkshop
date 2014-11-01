#pragma strict

/*
 * Door
 */

var closeRotation : Transform;
var openRotation : Transform;
var duration : float;

private var progress : float;
private var opening : boolean;

function Use () {
	print("Using Door");
	opening = !opening;
}

function Update(){


	if( opening ){
		progress = progress + Time.deltaTime;
	}
	else {
		progress = progress - Time.deltaTime;
	}
	
	if( progress > duration ){
		progress = duration;
	}
	
	if( progress < 0 ){
		progress = 0;
	}
	
	transform.rotation = Quaternion.Lerp( closeRotation.rotation, openRotation.rotation, progress / duration );
}