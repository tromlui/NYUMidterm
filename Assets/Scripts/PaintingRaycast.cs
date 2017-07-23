using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingRaycast : MonoBehaviour {

	public Transform paintDaub;
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit rayHit = new RaycastHit ();
		if (Physics.Raycast (ray, out rayHit, 100f)) {
			//paintDaub.position = rayHit.point;
			Instantiate (paintDaub, rayHit.point, Quaternion.Euler (0, 0, 0));
		}
	}
}
