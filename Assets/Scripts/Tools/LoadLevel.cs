using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour {

    public string levelName;

    public void Load(){
        SceneManager.LoadScene( levelName );
    }
}
