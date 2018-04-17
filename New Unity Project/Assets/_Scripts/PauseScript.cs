using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour {

	public bool paused;
	public GameObject PausePanel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void PauseGame(bool Paused)
	{
		if (Paused)
		{
			PausePanel.SetActive(true);
			Time.timeScale = 0;
		}
		else
		{
			PausePanel.SetActive(false);
			Time.timeScale = 1;
		}
	}
}
