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

	//public int responsesGiven;
	//public int badResponsesGiven;

	//public int totalResponses;

	//public GameObject strikeOne;
	//public GameObject strikeTwo;


	// Use this for initialization
	void Start () {
		dialogue = gameManager.GetComponent<DialogueTree> ();
		talk = gameManager.GetComponent<ConversationManager> ();
		stress = gameManager.GetComponent<StressingOut> ();
	}
	
	// Update is called once per frame
	void Update () {
		IsCorrect ();

		//totalResponses = responsesGiven + badResponsesGiven;

		//I was attempting to make it so that if you didn't respond for a while you would get a game over. It didn't work.
		/*
		if (totalResponses == dialogue.linesCounter - 1) {
			strikeOne.SetActive (true);
		}
		if (totalResponses == dialogue.linesCounter - 2) {
			strikeTwo.SetActive (true);
		}

		if (totalResponses == dialogue.linesCounter - 3) {
			talk.gameOverWords.SetActive (true);
		}
		*/
	}

	public void IsCorrect () {
		if (selfButton == dialogue.correctChoice) {
			isCorrectChoice = true;
			//responsesGiven += 1;
		} else {
			isCorrectChoice = false;
			//badResponsesGiven += 1;
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
