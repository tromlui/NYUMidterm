﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTree : MonoBehaviour {

	public Text dialogueText;
	public string[] dialogueLines;
	public GameObject[] choices;

	public float dialogueTime;

	public GameObject correctChoice;

	public float positiveEffect;
	public float negativeEffect;

	private ConversationManager cm;

	private MakingGoodChoices mgc;

	public int linesCounter;

	// Use this for initialization
	void Start () {
		cm = GetComponent<ConversationManager> ();
		mgc = GetComponent<MakingGoodChoices> ();
		NextDialogue (0);
		linesCounter = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void NextDialogue (int curLine) {
		StartCoroutine (DialogueTimer (dialogueTime));
	}

	/*
	public void ChoiceCheck () {
		if (mgc.isCorrectChoice) {
			cm.conversationLevel += positiveEffect;
		} else  if (!mgc.isCorrectChoice){
			cm.conversationLevel -= negativeEffect;
		}
	}
	*/

	IEnumerator DialogueTimer (float dialogueTime) {
		Debug.Log ("Coroutine will run now");
		yield return new WaitForSeconds(dialogueTime);
		for (int i = 0; i < dialogueLines.Length; i++) {
			int nextNumber = Random.Range(0,dialogueLines.Length);
			dialogueText.text = dialogueLines [nextNumber];
			correctChoice = choices [nextNumber];

			if (i == dialogueLines.Length - 1) {
				i = 0;
				StartCoroutine (DialogueTimer (dialogueTime));
			}

			/*
			if (mgc.responsesGiven == i - 1) {
				strikes = 1;
			} else if (mgc.responsesGiven == i - 2) {
				strikes = 2;
				GetComponent<AnxietyShake> ().shake = Mathf.Infinity;
			} else if (mgc.responsesGiven == i - 3) {
				cm.gameOverWords.SetActive (true);
			}
			*/
			linesCounter++;
			yield return new WaitForSeconds (dialogueTime);
		}
		Debug.Log ("Coroutine has run");
	}

}
