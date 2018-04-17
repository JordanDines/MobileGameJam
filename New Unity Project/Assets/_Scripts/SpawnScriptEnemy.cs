using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScriptEnemy : MonoBehaviour
{
	public float minTime = 3.0f;
	public float maxTime = 5.0f;
	public Transform[] spawnPoints;
	float spawnTimer;
	float timer;

	// Use this for initialization
	void Awake()
	{
		setRandomNumber();
		timer = minTime;

	}

	// Update is called once per frame
	void Update()
	{
		timer += Time.deltaTime;
		GameObject Vampire = ObjectPool.SharedInstance.GetPooledObject("Enemy");

		if (timer >= spawnTimer)
		{
			timer = 0;
			int spawnPointIndex = Random.Range(0, spawnPoints.Length);
			Vampire.transform.position = spawnPoints[spawnPointIndex].transform.position;
			Vampire.transform.rotation = spawnPoints[spawnPointIndex].transform.rotation;
			Vampire.SetActive(true);
		}
	}

	private void setRandomNumber()
	{
		spawnTimer = Random.Range(minTime, maxTime);
	}

}
