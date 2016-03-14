using UnityEngine;
using System.Collections;

public class DebrisController : MonoBehaviour {

	public Rigidbody2D movementRandomizer;

	public AudioSource hitEffect;

	// Use this for initialization
	void Start () {
		movementRandomizer.AddForce (new Vector2 ((Random.Range (-30000f, 30000f)), 0));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D c) {
		if (c.gameObject.tag == "Player") {
			ScreenShake.screenShakeAmt = 1.5f;
			hitEffect.Play ();
		}

		if (c.gameObject.tag == "Ground") {
			Destroy (this.gameObject);
		}

		if (c.gameObject.tag == "Bullet1" || c.gameObject.tag == "Bullet2") {
			Destroy (this.gameObject);
		}
			
	}
}
