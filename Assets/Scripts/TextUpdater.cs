using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextUpdater : MonoBehaviour {

	[SerializeField]
	private Text textUpdate = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		textUpdate.text = EnemyController.winText;
	
	}
}
