using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public GameObject myPlayer;
	public GameObject myButton0;
	public GameObject myButton1;
	public GameObject myButton2;
	//public Transform[] playerTransforms;

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
	private float m_FireCooldown;

	void Awake()
	{
		tm = FindObjectOfType<TransformManager>();
		m_FireCooldown = m_FireRate;
	}

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		m_FireCooldown += Time.deltaTime;
		
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
		//myPlayer.transform.position = Vector3.MoveTowards(myPlayer.transform.position, tm.playerTransforms[tm.currentTransform].position, speed * Time.deltaTime);
		//
		//if (myPlayer.transform.position == tm.playerTransforms[tm.currentTransform].position)
		//{
		//	isMovingLeft = false;
		//}


		//isMovingLeft = true;

		//myButton1.SetActive(false);
		//myButton2.SetActive(false);

		//myPlayer.transform.position = Vector3.MoveTowards(myPlayer.transform.position, left.transform.position, speed * Time.deltaTime);
		//if(myPlayer.transform.position == left.transform.position)
		//{
		//	myButton1.SetActive(true);
		//	myButton2.SetActive(true);
		//	isMovingLeft = false;
		//}
	}
	public void middleButton()
	{

		//if(isMovingRight == false && isMovingLeft == false)
		Shoot();

		
		//isMovingMid = true;

		//myButton0.SetActive(false);
		//myButton2.SetActive(false);

		//myPlayer.transform.position = Vector3.MoveTowards(myPlayer.transform.position, mid.transform.position, speed * Time.deltaTime);
		//if (myPlayer.transform.position == mid.transform.position || myPlayer.transform.position == left.transform.position || myPlayer.transform.position == right.transform.position)
		//{
		//	Shoot();
		//	//myButton0.SetActive(true);
		//	//myButton2.SetActive(true);
		//	//isMovingMid = false;
		//}
	}
	public void rightButton()
	{

		isMovingRight = true;
		movetimer = 0;
		if (tm.currentTransform < 2)
		{
			tm.currentTransform += 1;
			//transform.position += Vector3.left * speed * Time.deltaTime;
		}


		//isMovingRight = true;
		//myButton0.SetActive(false);
		//myButton1.SetActive(false);

		//myPlayer.transform.position = Vector3.MoveTowards(myPlayer.transform.position, right.transform.position, speed * Time.deltaTime);

		//if(myPlayer.transform.position == left.transform.position)
		//{
		//	isMovingRight = true;
		//}

		////if (myPlayer.transform.position == left.transform.position)
		////{
		////	myPlayer.transform.position = Vector3.MoveTowards(myPlayer.transform.position, mid.transform.position, speed * Time.deltaTime);
		////}
		////if(myPlayer.transform.position == mid.transform.position)
		////{
		////	myPlayer.transform.position = Vector3.MoveTowards(myPlayer.transform.position, right.transform.position, speed * Time.deltaTime);
		////}
		////myPlayer.transform.position = Vector3.MoveTowards(myPlayer.transform.position, right.transform.position, speed * Time.deltaTime);
		//if (myPlayer.transform.position == right.transform.position)
		//{
		//	myButton0.SetActive(true);
		//	myButton1.SetActive(true);
		//	isMovingRight = false;
		//}
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
		//if (isMovingLeft == false && isMovingRight)
		//{ 
			if (m_FireCooldown >= m_FireRate)
			{
				GameObject bullet = ObjectPool.SharedInstance.GetPooledObject("Bullet");
				if (bullet != null)
				{
					bullet.transform.position = spawnPos.transform.position;
					bullet.transform.rotation = spawnPos.transform.rotation;
					bullet.SetActive(true);
				}
				m_FireCooldown = 0;
				canShoot = false;
			}
		//}
	}
}