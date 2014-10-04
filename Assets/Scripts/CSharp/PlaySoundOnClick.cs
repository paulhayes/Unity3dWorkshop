using UnityEngine;
using System.Collections;

public class PlaySoundOnClick : MonoBehaviour 
{
	void OnMouseDown()
	{
		audio.Play();
	}
}
