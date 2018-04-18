using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveScript : MonoBehaviour
{
	public float speed;
	public float speedUpPoint;
	public float increaseSpeed;
	[SerializeField]
	private float nextSpeedUp;
	[SerializeField]
	private float maxSpeed;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position += Vector3.back * speed * Time.deltaTime;
		if (speed == maxSpeed) {
			speed = maxSpeed;
		}
		 else if (ScoreManager.score >= speedUpPoint)
		{
			speed += increaseSpeed;
			speedUpPoint += nextSpeedUp;
		}

	}
}
