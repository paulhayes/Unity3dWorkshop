using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DemosMenu : MonoBehaviour {

	public string[] scenes;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI(){
		GUI.matrix = Matrix4x4.TRS(Vector3.zero,Quaternion.identity,2f*Vector3.one);
	
		foreach(var scene in scenes){
			if( GUILayout.Button(scene)){
				SceneManager.LoadScene(scene);				
			}	
		}
	}
}
