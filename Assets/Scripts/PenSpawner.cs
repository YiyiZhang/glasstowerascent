using UnityEngine;
using System.Collections;

public class PenSpawner : MonoBehaviour {
	
	public GameObject pen2Spawn;
	public float speed = 500f;

	private float penStart = 3f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		penStart = penStart + 0.03f;

		if (Input.GetKeyDown ("down") && penStart > 3f) {

			Object o = Instantiate (pen2Spawn, this.transform.position, Quaternion.identity);
			GameObject p = (GameObject)o;
			Rigidbody2D penBullet = p.GetComponent<Rigidbody2D> ();
			penBullet.AddForce (this.transform.up * speed);

			penStart = 1f;

		}

	}
}
