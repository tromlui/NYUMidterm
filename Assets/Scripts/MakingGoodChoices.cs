using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakingGoodChoices : MonoBehaviour {

	public bool isCorrectChoice;

	private DialogueTree dialogue;
	private StressingOut stress;
	private ConversationManager talk;

	public GameObject gameManager;
	public GameObject selfButton;

	public float goodTalk;
	public float badTalk;
	public float goodStress;
	public float badStress;



	// Use this for initialization
	void Start () {
		dialogue = gameManager.GetComponent<DialogueTree> ();
		talk = gameManager.GetComponent<ConversationManager> ();
		stress = gameManager.GetComponent<StressingOut> ();
	}
	
	// Update is called once per frame
	void Update () {
		IsCorrect ();
	}

	public void IsCorrect () {
		if (selfButton == dialogue.correctChoice) {
			isCorrectChoice = true;
		} else {
			isCorrectChoice = false;
		}
	}

	public void StressTest () {
		if (isCorrectChoice) {
			talk.conversationLevel += goodTalk;
			stress.curStress -= goodStress;
		} else {
			talk.conversationLevel -= badTalk;
			stress.curStress += badStress;
		}
	}
}
