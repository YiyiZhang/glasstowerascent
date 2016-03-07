using UnityEngine;
using System.Collections;

public class DebrisController : MonoBehaviour {

	public Rigidbody2D movementRandomizer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		movementRandomizer.AddForce (new Vector2 (Random.Range (-30,30), 0));
	
	}
}
