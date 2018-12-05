using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotator : MonoBehaviour {

	public Sprite check; 
	public Button button; 


	private bool done = false;

	// Use this for initialization
	void Start () {
		button = GetComponent<Button> ();
	}

	public void OnMouseDown() {
		transform.Rotate (0,180,0);
		done = true;
	}

	// Update is called once per frame
	void Update () {
		//transform.Rotate (0, Time.deltaTime, 0);

		if (transform.rotation.eulerAngles.y == 180) {
			button.GetComponent<Image> ().sprite = check;
		}

		if (done) {
			transform.Rotate (0, 0, 0);
		}
	}
}
