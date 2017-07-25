using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConversationManager : MonoBehaviour {

	public float conversationLevel;
	public GameObject gameOverWords;
	public GameObject winWords;
	public float maxConversation;
	public GameObject backButton;

	private DialogueTree dialogue;
	private StressingOut stress;
	private EyeContact eye;

	// Use this for initialization
	void Start () {
		dialogue = GetComponent<DialogueTree> ();
		stress = GetComponent<StressingOut> ();
		eye = GetComponent<EyeContact> ();
		conversationLevel = 50f;
	}
	
	// Update is called once per frame
	void Update () {
		if (conversationLevel <= 0) {
			dialogue.dialogueText.text = "Well, this has been an awful conversation. Bye, weirdo.";
			stress.stressSpeed = 0;
			eye.eyeSpeed = 0;
			gameOverWords.SetActive (true);
			backButton.SetActive (true);
		}

		if (conversationLevel >= maxConversation) {
			dialogue.dialogueText.text = "That was a good conversation. We should talk again soon.";
			stress.stressSpeed = 0;
			eye.eyeSpeed = 0;
			winWords.SetActive (true);
			backButton.SetActive (true);
		}
	}
}
