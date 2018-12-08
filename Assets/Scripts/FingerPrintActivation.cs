using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FingerPrintActivation : MonoBehaviour {

	public Image img; 

	public float speed;

	// Use this for initialization
	void Start () {
		img.color = new Color (img.color.r, img.color.g, img.color.b, 0.3f); 	
	}

	public void OnClick() {
		StartCoroutine (AdjustAlpha ());
	}

	public IEnumerator AdjustAlpha() {
		while (img.color.a < 1.0f) {
			img.color = new Color (img.color.r, img.color.g, img.color.b, img.color.a + (Time.deltaTime / speed));
			yield return null;
		}
	}

}
