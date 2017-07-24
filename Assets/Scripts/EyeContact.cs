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

	private ConversationManager cm;
	public float conversationSpeed;


	// Use this for initialization
	void Start () {
		cm = GetComponent<ConversationManager> ();

	}

	// Update is called once per frame
	void FixedUpdate () {
		
		float percent = curEye/maxEye;
		eyeBar.transform.localScale = new Vector3 (percent, 1, 1);

		if (curEye > maxEye) {
			curEye = maxEye;
			cm.gameOverWords.SetActive (true);
		}

		if (curEye < 0) {
			curEye = 0;
			cm.gameOverWords.SetActive (true);
		}

		if (curEye > minEyeWarning && curEye < maxEyeWarning) {
			cm.conversationLevel += conversationSpeed;
			eyeBar.GetComponent<Image> ().color = Color.green;
		} else {
			cm.conversationLevel -= conversationSpeed;
			eyeBar.GetComponent<Image> ().color = Color.red;
		}


		/*
		if (curEye > maxEyeWarning) {
			GetComponent<AnxietyShake> ().shake = Mathf.Infinity;

			cm.conversationLevel -= cm.conversationLevel * conversationSpeed;
		}

		 if (curEye < minEyeWarning) {
			eyeBar.GetComponent<Image> ().color = Color.red;
			GetComponent<AnxietyShake> ().shake = Mathf.Infinity;
		}
		*/

		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit rayHit = new RaycastHit ();
		if (Physics.Raycast (ray, out rayHit, 100f)) {
			if (rayHit.transform.tag == "eye") {
				curEye += eyeSpeed * Time.deltaTime;
			} else {
				curEye -= eyeSpeed * Time.deltaTime;
			}
		}

		//MakingEyeContact ();
	}


	/*
	public void MakingEyeContact () {
		if (Input.GetKey (KeyCode.Mouse0)) {
			curEye += eyeSpeed * Time.deltaTime;
		} else {
			curEye -= eyeSpeed * Time.deltaTime;
		}
	}
	*/
}
