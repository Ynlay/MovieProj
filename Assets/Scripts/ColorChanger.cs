using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour {

	public Color colorRed = Color.red;
	public Color colorBlue = Color.blue;

	public float duration = 3.0f; 

	public Camera cam; 

	// Use this for initialization
	void Start () {
		cam = GetComponent<Camera> ();
		cam.clearFlags = CameraClearFlags.SolidColor;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			float t = Mathf.PingPong (Time.time, duration);
			cam.backgroundColor = Color.Lerp (colorRed, colorBlue, t);
		}

	}
}
