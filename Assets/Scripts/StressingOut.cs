﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StressingOut : MonoBehaviour {

	public GameObject stressBar;

	public static float maxStress = 100;
	public float curStress = 0;

	public float stressShake;

	public float stressSpeed;

	private ConversationManager cm;
	private DialogueTree dialogue;
	private EyeContact eye;

	//public float fidgetValue;

	// Use this for initialization
	void Start () {
		cm = GetComponent<ConversationManager> ();
		dialogue = GetComponent<DialogueTree> ();
		eye = GetComponent<EyeContact> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Stress ();

		float percent = curStress/maxStress;
		stressBar.transform.localScale = new Vector3 (1, percent, 1);

		if (curStress > maxStress) {
			cm.gameOverWords.SetActive (true);
			cm.backButton.SetActive (true);
			dialogue.dialogueText.text = "Are you okay? You're shaking.";
			eye.eyeSpeed = 0;
			stressSpeed = 0;
			curStress = maxStress;
		}

		if (curStress < 0) {
			curStress = 0;
		}

		if (curStress > stressShake) {
			stressBar.GetComponent<Image> ().color = Color.red;
			GetComponent<AnxietyShake> ().shake = Mathf.Infinity;
		} else {
			stressBar.GetComponent<Image> ().color = Color.green;
			GetComponent<AnxietyShake> ().StopShaking ();
		}
	}

	public void Stress () {
		curStress += stressSpeed * Time.deltaTime;
	}


	//this void is no longer necessary with a spererate fidget script
	/*
	public void Fidget () {
		curStress = curStress - fidgetValue;
	}
	*/ 
}
