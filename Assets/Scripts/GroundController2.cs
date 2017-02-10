using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController2 : MonoBehaviour {

	void FixedUpdate () {
		
		float moveX = Input.GetAxis ("Vertical");
		float moveZ = (Input.GetAxis ("Horizontal")) * (-1);

		Vector3 movement = new Vector3 (moveX, 0.0f, moveZ);

		transform.Rotate (movement);
	}


}

// notes

//public float speed;
//
//void FixedUpdate ()
//{
//	float moveHorizontal = Input.GetAxis ("Horizontal");
//	float moveVertical = Input.GetAxis ("Vertical");
//
//	Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
//
//	rb.AddForce (movement * speed);
//}
