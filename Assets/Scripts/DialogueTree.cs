using System.Collections;
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

	public bool isCorrectChoice;

	// Use this for initialization
	void Start () {
		cm = GetComponent<ConversationManager> ();
		NextDialogue (0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void NextDialogue (int curLine) {
		StartCoroutine (DialogueTimer (dialogueTime));
	}

	public void ChoiceCheck () {
		if (correctChoice) {
			cm.conversationLevel += positiveEffect;
		} else  if (!correctChoice){
			cm.conversationLevel -= negativeEffect;
		}
	}

	IEnumerator DialogueTimer (float dialogueTime) {
		Debug.Log ("Coroutine will run now");
		yield return new WaitForSeconds(dialogueTime);
		for (int i = 0; i < dialogueLines.Length; i++) {
			int nextNumber = Random.Range(0,dialogueLines.Length);
			dialogueText.text = dialogueLines [nextNumber];
			correctChoice = choices [nextNumber];

			if (i >= dialogueLines.Length) {
				i = 0;
			}
			yield return new WaitForSeconds (dialogueTime);
		}
		Debug.Log ("Coroutine has run");
	}

}
