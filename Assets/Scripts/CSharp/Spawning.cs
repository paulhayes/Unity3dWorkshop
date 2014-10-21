using UnityEngine;
using System.Collections;

public class Spawning : MonoBehaviour {

	public GameObject prefab;

	void Spawn (Vector3 position) {
		Instantiate( prefab, position, Quaternion.identity );
	}
}
