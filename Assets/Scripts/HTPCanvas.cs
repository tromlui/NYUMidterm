using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HTPCanvas : MonoBehaviour {

	public GameObject playButton;
	public GameObject HTPGroup;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void HowToPlay () {
		HTPGroup.SetActive (true);
	}
}
