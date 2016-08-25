using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {

    public ParticleSystem[] particles;
    public ConstantForce force;
    public KeyCode key;
    public Fuel fuel;
    public bool ignited;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	    if( Input.GetKeyDown(key) ){
            ignited = true;
            foreach(var particle in particles ){
                particle.Play();
            }

        }

        if( ignited ){
            fuel.quantity -= Time.deltaTime;
        }
        if( fuel.quantity <= 0 && force  ){
            foreach(var particle in particles ){
                particle.Stop();
            }
        }
        force.enabled = (fuel.quantity>0) && (ignited);

	}


}
