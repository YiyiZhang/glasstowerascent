using UnityEngine;
using System.Collections;

public class PencilSpawner : MonoBehaviour {

	public GameObject pencil2Spawn;
	public float speed = 500f;

	private float pencilStart = 3f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		pencilStart = pencilStart + 0.03f;

			if (Input.GetKeyDown ("s") && pencilStart > 3f) {

				Object o = Instantiate (pencil2Spawn, this.transform.position, Quaternion.identity);
				GameObject p = (GameObject)o;
				Rigidbody2D pencilBullet = p.GetComponent<Rigidbody2D> ();
				pencilBullet.AddForce (this.transform.up * speed);
				pencilStart = 1f;
			
			}
	}
}
