using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player1Mover : MonoBehaviour {

	public Rigidbody2D player1Jump;
	bool onPlatform = false;

	public Animator player1Walking;
	public Animator player1Jumping;

	public int startingHealth = 100;

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
		}

		if (c.gameObject.tag == "Bullet2" && this.gameObject.transform.position.y > 5) {
			this.gameObject.transform.position = new Vector3 (this.gameObject.transform.position.x, this.gameObject.transform.position.y - 3f);
			Destroy (c.gameObject);
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

	void Update () {

		bool isWalking = false;
		bool isJumping = false;

		Vector3 localScale = player1Jump.transform.localScale;

		if (Input.GetKeyDown ("w") && onPlatform == true) {
			player1Jump.AddForce (new Vector2 (0, 700));
			isJumping = true;

		} else if (Input.GetKeyDown ("up") && onPlatform == false) {
			player1Jump.AddForce (new Vector2 (0, 0));
			isJumping = true;
		}

		if (Input.GetKey ("a")) {
			player1Jump.AddForce (new Vector2 (-20, 0));
			isWalking = true;
			localScale.x = -3f;
		}

		if (Input.GetKey ("d")) {
			player1Jump.AddForce (new Vector2 (20, 0));
			isWalking = true;
			localScale.x = 3f;
		}

		player1Walking.SetBool ("isWalking", isWalking);
		player1Jumping.SetBool ("isJumping", isJumping);
	 
		player1Jump.transform.localScale = localScale;

			

	}

}