using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveScript : MonoBehaviour
{
	public float speed;
	public float speedUpPoint;
	public float increaseSpeed;
	public float nextSpeedUp;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (ScoreManager.score >= speedUpPoint)
		{
			speed += increaseSpeed;
			speedUpPoint += nextSpeedUp;
		}
		transform.position += Vector3.back * speed * Time.deltaTime;
	}
}
