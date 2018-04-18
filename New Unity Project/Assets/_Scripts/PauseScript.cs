using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour {

	public bool paused;
	public GameObject PausePanel;
	public GameObject pauseButton;


	void Awake () {
		Time.timeScale = 1;
	}
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
			pauseButton.SetActive(false);
			PausePanel.SetActive(true);
			Time.timeScale = 0;
		}
		else
		{
			pauseButton.SetActive(true);
			PausePanel.SetActive(false);
			Time.timeScale = 1;
		}
	}
}
