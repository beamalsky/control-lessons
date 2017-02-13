using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController3 : MonoBehaviour {

	public Text countText;
	public Text winText;

	private int count;

	void Start ()
	{
		count = 0;
		SetCountText ();
		winText.text = "";
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