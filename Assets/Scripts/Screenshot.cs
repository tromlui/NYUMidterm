using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screenshot : MonoBehaviour {

	public int picCount = 0;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Return)) {
			print ("ScreenShot #" + picCount);
			Application.CaptureScreenshot ("Screenshot" + picCount + ".png");
			picCount++;
		}
	}
}
