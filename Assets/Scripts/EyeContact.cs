using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EyeContact : MonoBehaviour {

	public GameObject eyeBar;

	public float maxEye = 100;
	public float minEye = 0;
	public float curEye = 50;
	public float minEyeWarning = 20;
	public float maxEyeWarning = 80;

	public float eyeSpeed;

	public GameObject eyeButton;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void FixedUpdate () {
		
		float percent = curEye/maxEye;
		eyeBar.transform.localScale = new Vector3 (percent, 1, 1);

		if (curEye > maxEye) {
			curEye = maxEye;
		}

		if (curEye > maxEyeWarning) {
			GetComponent<AnxietyShake> ().shake = Mathf.Infinity;
		}

		if (curEye < minEyeWarning) {
			eyeBar.GetComponent<Image> ().color = Color.red;
			GetComponent<AnxietyShake> ().shake = Mathf.Infinity;
		}

		MakingEyeContact ();
	}

	public void MakingEyeContact () {
		if (Input.GetKey (KeyCode.Mouse0)) {
			curEye += eyeSpeed * Time.deltaTime;
		} else {
			curEye -= eyeSpeed * Time.deltaTime;
		}
	}
}
