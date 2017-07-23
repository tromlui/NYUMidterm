using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoombaRaycast : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		Ray ray = new Ray (transform.position, transform.forward);
		Debug.DrawRay (ray.origin, ray.direction * 3f, Color.yellow);
		if (Physics.Raycast (ray, 3f)) {
			float randomNumber = Random.Range (0f, 100f);
			if (randomNumber < 50f) {
				transform.Rotate (0f, -90f, 0f);
			} else {
				transform.Rotate (0f, 90f, 0f);
			}
		} else {
			transform.Translate (0f, 0f, 5f * Time.deltaTime);
		}
	}
}
