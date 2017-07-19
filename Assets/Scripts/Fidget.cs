using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fidget : MonoBehaviour {

	public float fidgetValue;

	private StressingOut stress;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		StressOutlet ();
	}

	public void StressOutlet () {
		stress.curStress -= fidgetValue;
	}
}
