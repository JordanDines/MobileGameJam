using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltMovement : MonoBehaviour {
	public float m_fSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.forward * m_fSpeed * Time.deltaTime;
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Enemy")
		{
			ScoreManager.score++;
			gameObject.SetActive(false);
			Destroy(collision.gameObject);
		}
		else
		{
			gameObject.SetActive(false);
		}
	}
}
