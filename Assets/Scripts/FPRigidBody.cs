using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPRigidBody : MonoBehaviour {

	public Vector3 inputVector;
	private Rigidbody rb;

	public float speed;
	public float gravityScale;

	public float mouseSensitivity;

	private float mouseY;
	public float downAngle;
	public float upAngle;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		inputVector.x = Input.GetAxis ("Horizontal");
		inputVector.y = gravityScale;
		inputVector.z = Input.GetAxis ("Vertical");

		transform.Rotate (0f, Input.GetAxis ("Mouse X") * Time.deltaTime * mouseSensitivity, 0f); 
		mouseY -= Input.GetAxis ("Mouse Y") * Time.deltaTime * mouseSensitivity;
		mouseY = Mathf.Clamp (mouseY, downAngle, upAngle);

		Camera.main.transform.localEulerAngles = new Vector3 (mouseY, 0f, 0f);


		if (Input.GetMouseButtonDown (0)) {
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
		}
	}

	void FixedUpdate () {
		Vector3 worldVector = transform.right * inputVector.x + transform.up * inputVector.y + transform.forward * inputVector.z;
		//rb.AddForce (worldVector *  speed);

		rb.velocity = worldVector * speed;
	}
}
