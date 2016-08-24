using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class Wait : MonoBehaviour {

    public float delayDuration;
    public UnityEvent then;

	public void Activate(){
        StartCoroutine(_Activate());
    }

    IEnumerator _Activate(){
        yield return new WaitForSeconds(delayDuration);
        then.Invoke();
    }
}
