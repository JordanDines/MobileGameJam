using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

using UnityEngine;

public class EnemyScript : MonoBehaviour
{
	int Score = 0;
	public Text scoreText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Bullet")
		{
			Score++;
			setScoreText();
		}
	}
	private void setScoreText()
	{
		scoreText.text = Score.ToString();
	}
}
