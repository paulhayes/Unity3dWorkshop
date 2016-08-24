using UnityEngine;
using System.Collections;

public class PlaySoundOnClick : MonoBehaviour 
{
	void OnMouseDown()
	{
		GetComponent<AudioSource>().Play();
	}
}
