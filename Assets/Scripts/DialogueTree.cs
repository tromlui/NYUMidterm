using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTree : MonoBehaviour {

	public Text dialogueText;
	public string[] dialogueLines;
	public Button[] choices;

	public float dialogueTime;
	public float choiceTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void NextDialogue (int curLine) {
		for (int i = 0; i < dialogueLines.Length; i++) {
			if (i == curLine) {
				dialogueText.text = dialogueLines [i];
			} else {
				dialogueText.text = "There's a bug in the code!";
			}
		}
	}
}
