using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class SceneAdvance : MonoBehaviour {

	//current scene
	private int x;
	//next scene
	private int y;

	void AdvanceFunction () {
		x = SceneManager.GetActiveScene ().buildIndex;
		y = x + 1;
		SceneManager.LoadScene (y);
		Debug.Log("I've just been clicked");
	}
}