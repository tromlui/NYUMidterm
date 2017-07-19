using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StressingOut : MonoBehaviour {

	public GameObject stressBar;

	public static float maxStress = 100;
	public float curStress = 0;

	public float stressShake;

	public float stressSpeed;

	public float fidgetValue;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Stress ();

		float percent = curStress/maxStress;
		stressBar.transform.localScale = new Vector3 (1, percent, 1);

		if (curStress > maxStress) {
			curStress = maxStress;
		}

		if (curStress < 0) {
			curStress = 0;
		}

		if (curStress > stressShake) {
			stressBar.GetComponent<Image> ().color = Color.red;
			GetComponent<AnxietyShake> ().shake = Mathf.Infinity;
		}
	}

	public void Stress () {
		curStress += stressSpeed * Time.deltaTime;
	}

	public void Fidget () {
		curStress = curStress - fidgetValue;
	}
}
