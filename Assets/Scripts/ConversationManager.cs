using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConversationManager : MonoBehaviour {

	public float conversationLevel;
	public GameObject gameOverWords;
	public GameObject winWords;
	public float maxConversation;

	// Use this for initialization
	void Start () {
		conversationLevel = 50f;
	}
	
	// Update is called once per frame
	void Update () {
		if (conversationLevel <= 0) {
			gameOverWords.SetActive (true);
		}

		if (conversationLevel >= maxConversation) {
			winWords.SetActive (true);
		}
	}
}
