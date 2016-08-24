#pragma strict

/*
 * Door
 */

var closeRotation : Transform;
var openRotation : Transform;
var duration : float;

private var progress : float;
private var opening : boolean;

public function ToggleDoor () {
	print("Using Door");
	opening = !opening;
}

public function OpenDoor(){
	opening = true;
}

public function CloseDoor(){
	opening = false;
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