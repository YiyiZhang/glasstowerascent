using UnityEngine;
using System.Collections;

public class FinalPlatformController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D c) {

		if (c.gameObject.tag == "Bullet1" || c.gameObject.tag == "Bullet2") {
			Destroy (c.gameObject);
		}

	}
}
