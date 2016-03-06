using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public Transform playerPos;
	public Transform playerPos2;

	Vector3 setCameraPos2PlayerPos;
	Vector3 setCameraPos2Player2Pos;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {

		if (playerPos.transform.localPosition.y > playerPos2.transform.localPosition.y) {

			setCameraPos2PlayerPos = new Vector3 (playerPos.transform.localPosition.x, playerPos.transform.localPosition.y, playerPos.transform.localPosition.z - 20);
			transform.position = setCameraPos2PlayerPos;

		} else if (playerPos2.transform.localPosition.y > playerPos.transform.localPosition.y) {
	
			setCameraPos2Player2Pos = new Vector3 (playerPos2.transform.localPosition.x, playerPos2.transform.localPosition.y, playerPos2.transform.localPosition.z - 20);
			transform.position = setCameraPos2Player2Pos;

		}
	}
}
