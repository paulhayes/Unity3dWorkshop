#pragma strict

var OnUseEvent : UnityEngine.Events.UnityEvent;

function Use(){
	OnUseEvent.Invoke();
}