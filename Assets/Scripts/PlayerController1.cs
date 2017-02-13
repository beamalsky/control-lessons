using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController1 : MonoBehaviour {

	public float speed;
	public Text countText;
	public Text winText;
	public Button advanceButton;

	private Rigidbody rb;
	private Transform tf;
	private int count;

	//current scene
	private int x;
	//next scene
	private int y;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		tf = GetComponent<Transform>();
		count = 0;
		SetCountText ();
		winText.text = "";
		x = SceneManager.GetActiveScene ().buildIndex;
		y = x + 1;
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);

		//reset scene if ball falls
		if (tf.position.y < -30) {
			SceneManager.LoadScene (x);
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
		}
	}

	void SetCountText () {
		countText.text = "Cube Count = " + count.ToString ();
		if (count >= 14) {
			AdvanceScene ();
			//advanceButton.gameObject.SetActive (true);
		}
	}

	void AdvanceScene () {
		SceneManager.LoadScene (y);
	}
}