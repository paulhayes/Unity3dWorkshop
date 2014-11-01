#pragma strict

/*
 * AgentFollow
 */

var target : Transform;
var updateInterval : float;
private var navMeshAgent : NavMeshAgent;

function Start () {
	navMeshAgent = GetComponent(NavMeshAgent);
	InvokeRepeating("Follow",updateInterval,updateInterval);
}

function Follow () {
	navMeshAgent.SetDestination(target.position);
}