using UnityEngine;
using System.Collections;

public class Player1Mover : MonoBehaviour {

	public Rigidbody2D player1Jump;
	bool onPlatform = false;

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

		if (Input.GetKeyDown ("w") && onPlatform == true) {
			player1Jump.AddForce (new Vector2 (0, 300));
		} else if (Input.GetKeyDown ("up") && onPlatform == false) {
			player1Jump.AddForce (new Vector2 (0, 0));
		}

		if (Input.GetKeyDown ("a")) {
			player1Jump.AddForce (new Vector2 (-100, 0));
		}

		if (Input.GetKeyDown ("d")) {
			player1Jump.AddForce (new Vector2 (100, 0));
		}

	}

}