﻿using UnityEngine;
using System.Collections;

public class Player2Mover : MonoBehaviour {

	public Rigidbody2D player2Jump;
	bool onPlatform = false;

	public Animator player2Walking;
	public Animator player2Jumping;

	public AudioSource ladyGrunt;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame

	void OnCollisionStay2D (Collision2D c){ //called every frame

		if (c.gameObject.tag == "Floor") {
			onPlatform = true;
		} else if (c.gameObject.tag != "Floor") {
			onPlatform = false;
		}

		if (c.gameObject.tag == "Debris" && this.gameObject.transform.position.y > 5) {
			this.gameObject.transform.position = new Vector3 (this.gameObject.transform.position.x, this.gameObject.transform.position.y - 5f);
			ScreenShake.screenShakeAmt = 2f;
			ladyGrunt.Play ();
		}

		if (c.gameObject.tag == "Bullet1" && this.gameObject.transform.position.y > 3) {
			this.gameObject.transform.position = new Vector3 (this.gameObject.transform.position.x, this.gameObject.transform.position.y - 3f);
			ScreenShake.screenShakeAmt = 2f;
			Destroy (c.gameObject);
			ladyGrunt.Play ();
		}

	}

	void OnCollisionExit2D (Collision2D c){
		if (c.gameObject.tag == "Floor") {
			onPlatform = false;
		}
	}

	//void OnGUI (){
		//GUI.Button (new Rect (10, 10, 100, 100), "on platform: " + onPlatform);
	//}

	void FixedUpdate () {
				
		bool isWalking = false;
		bool isJumping = false;

		Vector3 localScale = player2Jump.transform.localScale;

		if (Input.GetKeyDown ("up") && onPlatform) {
			player2Jump.AddForce (new Vector2 (0, 500));
			isJumping = true;
			isWalking = false;

		} else if (Input.GetKeyDown ("up") && onPlatform == false) {
			player2Jump.AddForce (new Vector2 (0, 0));
			isWalking = false;
		}

		if (Input.GetKey ("left")) {
			player2Jump.AddForce (new Vector2 (-20, 0));
			isWalking = true;
			localScale.x = 3f;
		}

		if (Input.GetKey ("right")) {
			player2Jump.AddForce (new Vector2 (20, 0));
			isWalking = true;
			localScale.x = -3f;
		}

		player2Walking.SetBool ("isWalking", isWalking);
		player2Jumping.SetBool ("isJumping", isJumping);

		player2Jump.transform.localScale = localScale;

	}
}
