#pragma strict

/*
 * AgentFollow
 */

var target : Transform;
var updateInterval : float;
private var navMeshAgent : NavMeshAgent;

function Start () {
	navMeshAgent = GetComponent(NavMeshAgent);
}

function Follow () {	
	navMeshAgent.SetDestination(target.position);
}

function OnEnable(){
	InvokeRepeating("Follow",updateInterval,updateInterval);

}

function OnDisable(){
	CancelInvoke();
}