using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fidget : MonoBehaviour {

	public float fidgetValue;

	public GameObject fidgetSpinner;

	private StressingOut stress;

	public float rotateSpeed;

	// Use this for initialization
	void Start () {
		stress = GetComponent<StressingOut> ();
	}
	
	// Update is called once per frame
	/*
	void Update () {
		StressOutlet ();
	}
	*/

	public void StressOutlet () {
		//fidgetSpinner.transform.Rotate (0, 90, 0);
		fidgetSpinner.GetComponent<Rigidbody> ().AddTorque (0f, rotateSpeed, 0f);
		stress.curStress -= fidgetValue;

	}
}
