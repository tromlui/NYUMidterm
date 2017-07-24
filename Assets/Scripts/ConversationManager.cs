using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConversationManager : MonoBehaviour {

	public float conversationLevel;
	public GameObject gameOverWords;
	public GameObject winWords;
	public float maxConversation;

	private DialogueTree dialogue;

	// Use this for initialization
	void Start () {
		dialogue = GetComponent<DialogueTree> ();
		conversationLevel = 50f;
	}
	
	// Update is called once per frame
	void Update () {
		if (conversationLevel <= 0) {
			dialogue.dialogueText.text = "Well, this has been an awful conversation. Bye, weirdo.";
			gameOverWords.SetActive (true);
		}

		if (conversationLevel >= maxConversation) {
			dialogue.dialogueText.text = "That was a good conversation. We should talk again soon.";
			winWords.SetActive (true);
		}
	}
}
