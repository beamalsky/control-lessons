using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController3 : MonoBehaviour {

	public Text countText;
	public Text winText;

	private Transform tf;
	private int count;

	//current scene
	private int x;

	void Start ()
	{
		count = 0;
		SetCountText ();
		winText.text = "";
		tf = GetComponent<Transform>();
		x = SceneManager.GetActiveScene ().buildIndex;
	}

	//reset scene if ball falls
	void Update () {
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
			winText.text = "You win!";
		}
	}
}