using UnityEngine;
using System.Collections;

public class SpawnPrefab : MonoBehaviour {

    public GameObject prefab;
    public int numberToSpawn=1;

	public void Spawn(){
        Spawn(transform.position);
    }

    public void Spawn(Vector3 position){
        if( numberToSpawn > 0 ){
            Instantiate(prefab, position, transform.rotation);
            numberToSpawn--;
        }

    }
}
