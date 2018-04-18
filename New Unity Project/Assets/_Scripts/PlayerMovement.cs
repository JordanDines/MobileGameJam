using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public GameObject myPlayer;
	public GameObject myButton0;
	public GameObject myButton1;
	public GameObject myButton2;

	private TransformManager tm;
	float movetime = 0.5f;
	float movetimer = 0.0f;
	int currentTransform;
	float speed = 10.0f;
	public bool isMovingLeft;
	public bool canShoot;
	public bool isMovingRight;

	[SerializeField]
	private GameObject m_Player;
	[SerializeField]
	private GameObject m_CrossBowBoltPrefab;
	[SerializeField]
	private Transform spawnPos;
	
	public float m_FireRate;
	[SerializeField]
	public float m_FireCooldown;

	public GameObject readyCrossbow;
	public GameObject shotCrossbow;

	public AudioSource audioToPlay;

	void Awake()
	{
		tm = FindObjectOfType<TransformManager>();
	}
		
	void Start ()
	{
		
	}


	void Update ()
	{
		


		Debug.Log(tm.currentTransform);
		if (isMovingLeft == true)
		{
			MoveLeft();
		}
		if (canShoot == true)
		{
			middleButton();
		}
		if (isMovingRight == true)
		{
			MoveRight();
		}
	}

	public void leftButton()
	{

		isMovingLeft = true;
		movetimer = 0;
		if (tm.currentTransform > 0)
		{
			tm.currentTransform--;
		}

	}
	public void middleButton()
	{
		if (m_FireCooldown >= m_FireRate) {
			Shoot ();
			audioToPlay.Play ();
		} else {
			return;
		}
	}
	public void rightButton()
	{

		isMovingRight = true;
		movetimer = 0;
		if (tm.currentTransform < 2)
		{
			tm.currentTransform += 1;
		}



	}
	void MoveLeft ()
	{
		myPlayer.transform.position = Vector3.MoveTowards(myPlayer.transform.position, tm.playerTransforms[tm.currentTransform].position, speed * Time.deltaTime);

		if (myPlayer.transform.position == tm.playerTransforms[tm.currentTransform].position)
		{
			isMovingLeft = false;
		}
	}

	void MoveRight()
	{
		myPlayer.transform.position = Vector3.MoveTowards(myPlayer.transform.position, tm.playerTransforms[tm.currentTransform].position, speed * Time.deltaTime);

		if (myPlayer.transform.position == tm.playerTransforms[tm.currentTransform].position)
		{
			isMovingRight = false;
		}
	}

	public void Shoot()
	{
			if (m_FireCooldown >= m_FireRate)
			{
			
				GameObject bullet = ObjectPool.SharedInstance.GetPooledObject("Bullet");
				if (bullet != null)
				{
				m_FireCooldown = 0;

					bullet.transform.position = spawnPos.transform.position;
					bullet.transform.rotation = spawnPos.transform.rotation;
					bullet.SetActive(true);

				}
				
				canShoot = false;
			}
	}
}