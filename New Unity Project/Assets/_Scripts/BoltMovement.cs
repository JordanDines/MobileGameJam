using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltMovement : MonoBehaviour {
	public float m_fSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position += transform.forward * m_fSpeed * Time.deltaTime;
	}


	private void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Enemy")
		{
			ScoreManager.score++;
			gameObject.SetActive(false);
			other.gameObject.SetActive(false);
		}
			gameObject.SetActive(false);
	}
}
