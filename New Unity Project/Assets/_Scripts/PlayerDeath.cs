using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour {


	public GameObject gameControls;
	public GameObject deathScreen;


	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Enemy") {
			Time.timeScale = 0;
			gameControls.SetActive (false);
			deathScreen.SetActive (true);
		}
	}
}
