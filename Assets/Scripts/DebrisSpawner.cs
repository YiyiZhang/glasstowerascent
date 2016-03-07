using UnityEngine;
using System.Collections;

public class DebrisSpawner : MonoBehaviour {

	    public GameObject object2Spawn;
	    public float spawnRate;

	    // Use this for initialization
	    void Start () {
		        InvokeRepeating ("Spawn", 3f, 5f);
		    }
	    
	    // Update is called once per frame
	    void Spawn () {
		        Instantiate (object2Spawn);
		    }
}

