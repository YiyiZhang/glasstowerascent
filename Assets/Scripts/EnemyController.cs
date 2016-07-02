using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour {

	public float speed = 0.1f;

	int hitCount = 0;

	public static string winText = "CLIMB THAT TOWER";

	public AudioSource enemyHitEffect;
	public AudioSource enemyDeadEffect;

	public ParticleSystem kaboom;

	int sceneLoadCountdown = 1;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {		
		this.transform.position = this.transform.position - new Vector3 (speed, Random.Range(-0.1f, 0.1f), 0);
	}

	void OnCollisionEnter2D (Collision2D c) {

		if (c.gameObject.tag == "Bullet1" || c.gameObject.tag == "Bullet2") {

			hitCount = hitCount + 1;
			Destroy (c.gameObject);
			print (hitCount);
			ScreenShake.screenShakeAmt = 1.5f;

			if (hitCount < 5 && (c.gameObject.tag == "Bullet1" || c.gameObject.tag == "Bullet2")) {
				enemyHitEffect.Play ();
			}

			if (hitCount == 3 && c.gameObject.tag == "Bullet1") {
				enemyDeadEffect.Play ();
				winText = "PLAYER 1 WINS";
				ScreenShake.screenShakeAmt = 5f;
				print (winText);
				kaboom.Play ();
				Invoke ("SceneLoadCountdown", 1.1f);
				Destroy (this.gameObject, 3f);
			}

			if (hitCount == 3 && c.gameObject.tag == "Bullet2") {
				enemyDeadEffect.Play ();
				winText = "PLAYER 2 WINS";
				ScreenShake.screenShakeAmt = 5f;
				print (winText);
				kaboom.Play ();
				Invoke ("SceneLoadCountdown", 1.1f);
				Destroy (this.gameObject, 3f);
			}

		}

	}

	void SceneLoadCountdown () {

		while (sceneLoadCountdown < 1000) {
			sceneLoadCountdown = sceneLoadCountdown + 1;
			print (sceneLoadCountdown);
		}

		if (sceneLoadCountdown == 2000) {
			SceneManager.LoadScene (3); //loads level 2
		}
		
	}
}
