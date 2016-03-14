using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public Transform player1;
	public Transform player2;
	public float lerpTime = 3f;

	Vector3 cameraPos;
//	Vector3 setCameraPos2Player2Pos;

	private Transform camTransform;

	// Use this for initialization
	void Start () {
		camTransform = Camera.main.transform;
	}

	// Update is called once per frame
	void Update () {

//		if (playerPos.transform.localPosition.y > playerPos2.transform.localPosition.y) {

//			setCameraPos2PlayerPos = new Vector3 (playerPos.transform.localPosition.x, playerPos.transform.localPosition.y + 3.5f, playerPos.transform.localPosition.z - 10);
//			transform.position = setCameraPos2PlayerPos;

//		} else if (playerPos2.transform.localPosition.y > playerPos.transform.localPosition.y) {
	
//			setCameraPos2Player2Pos = new Vector3 (playerPos2.transform.localPosition.x, playerPos2.transform.localPosition.y + 3.5f, playerPos2.transform.localPosition.z - 10);
//			transform.position = setCameraPos2Player2Pos;

//		}

		if (player1.transform.position.y > player2.transform.position.y){
			//cameraPos = new Vector3 (camTransform.position.x, player1.position.y, camTransform.position.z);
			Vector3 targetPos = new Vector3 (camTransform.position.x, player1.position.y + 2.5f, camTransform.position.z);
			cameraPos = Vector3.Lerp (cameraPos, targetPos, lerpTime * Time.deltaTime);

		} else {
			//cameraPos = new Vector3 (camTransform.position.x, player2.position.y, camTransform.position.z);
			Vector3 targetPos = new Vector3 (camTransform.position.x, player2.position.y + 2.5f, camTransform.position.z);
			cameraPos = Vector3.Lerp (cameraPos, targetPos, lerpTime * Time.deltaTime);
		}

		camTransform.position = cameraPos;
	
	}
}
