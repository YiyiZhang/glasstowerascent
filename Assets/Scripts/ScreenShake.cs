using UnityEngine;
using System.Collections;

public class ScreenShake : MonoBehaviour {

	public static float screenShakeAmt = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//makes screenshake amount decrease over time
		if (screenShakeAmt > 0) {
			screenShakeAmt = screenShakeAmt - Time.deltaTime; //Time.deltaTime is how much time has passed during this update
		}

		if (screenShakeAmt < 0) {
			screenShakeAmt = 0;
		}

		float randomY = Random.Range (-1f, 1f) * screenShakeAmt;
		float randomX = Random.Range (-1f, 1f) * screenShakeAmt;

		this.transform.position = new Vector3 (randomX, randomY, 0f);
	
	}
}
