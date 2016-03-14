using UnityEngine;
using System.Collections;

public class WallController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D c){
		if (c.gameObject.tag == "Enemy") {
			EnemyController asCont = c.gameObject.GetComponent<EnemyController> ();
			asCont.speed = -asCont.speed;
		}
	}
}
