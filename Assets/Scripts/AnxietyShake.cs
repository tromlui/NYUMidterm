using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnxietyShake : MonoBehaviour {

	public float shake = 0;
	public float shakeAmount = 0.7f;
	public float decreaseFactor = 1.0f;

	public Transform camTransform;
	private Vector3 originalPos;

	// Use this for initialization
	void Start () {
		if (camTransform == null) {
			camTransform = Camera.main.transform;
		}
		originalPos = camTransform.localPosition;

	}

	// Update is called once per frame
	void Update () {
		if (shake > 0) {
			camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;
			shake -= Time.deltaTime * decreaseFactor;
		} else {
			shake = 0f;
			camTransform.localPosition = originalPos;
		}

	}
}