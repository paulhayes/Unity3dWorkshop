#pragma strict
/*
 * CopterController
 */

public var frontLeft : CopterMotor;
public var frontRight : CopterMotor;
public var rearLeft : CopterMotor;
public var rearRight : CopterMotor;

public var upThrust : float;
public var forwardThrust : float;
public var rollThrust : float;
public var yawThrust : float;

public var engineOn;

function Start () {
	engineOn = false;
}

function Update () {

	if( Input.GetKeyDown( KeyCode.Space ) ){
		engineOn = !engineOn;
	}

	if( Input.GetKeyDown( KeyCode.Equals ) ){
		upThrust += 0.025;	
	}
	if( Input.GetKeyDown( KeyCode.Minus ) ){
		upThrust -= 0.025;
	}
		
	upThrust = Mathf.Clamp( upThrust, 0f, 3f );

	var pitch : float = forwardThrust * Input.GetAxis("Vertical");
	var roll : float = rollThrust * Input.GetAxis("Horizontal");
	
	if( engineOn ){
		frontLeft.thrust = upThrust + roll;
		frontRight.thrust = upThrust - roll;
		rearLeft.thrust = upThrust + pitch + roll;
		rearRight.thrust = upThrust + pitch - roll;
		
	}
	else {
		frontLeft.thrust = 0;
		frontRight.thrust = 0;
		rearLeft.thrust = 0;
		rearRight.thrust = 0;
	}
	
	
}

function FixedUpdate(){
	if( Input.GetKey( KeyCode.E ) ){
		rigidbody.AddRelativeTorque( yawThrust * Vector3.up );	
	} 
	if( Input.GetKey( KeyCode.Q ) ){
		rigidbody.AddRelativeTorque( -yawThrust * Vector3.up );
	} 

}