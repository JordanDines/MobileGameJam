using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public GameObject myPlayer;
	public GameObject myButton0;
	public GameObject myButton1;
	public GameObject myButton2;
	public Transform left;
	public Transform right;
	public Transform mid;
	float speed = 10;
	public bool isMovingLeft;
	public bool isMovingMid;
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


		if (isMovingLeft == true)
		{
			leftButton();
		}
		if (isMovingMid == true)
		{
			middleButton();
		}
		if (isMovingRight == true)
		{
			rightButton();
		}
	}
	public void leftButton()
	{
		isMovingLeft = true;

		myButton1.SetActive(false);
		myButton2.SetActive(false);

		myPlayer.transform.position = Vector3.MoveTowards(myPlayer.transform.position, left.transform.position, speed * Time.deltaTime);
		if(myPlayer.transform.position == left.transform.position)
		{
			Shoot();
			myButton1.SetActive(true);
			myButton2.SetActive(true);
			isMovingLeft = false;
		}
	}
	public void middleButton()
	{
		isMovingMid = true;

		myButton0.SetActive(false);
		myButton2.SetActive(false);

		myPlayer.transform.position = Vector3.MoveTowards(myPlayer.transform.position, mid.transform.position, speed * Time.deltaTime);
		if (myPlayer.transform.position == mid.transform.position)
		{
			Shoot();
			myButton0.SetActive(true);
			myButton2.SetActive(true);
			isMovingMid = false;
		}
	}
	public void rightButton()
	{
		isMovingRight = true;
		myButton0.SetActive(false);
		myButton1.SetActive(false);

		myPlayer.transform.position = Vector3.MoveTowards(myPlayer.transform.position, right.transform.position, speed * Time.deltaTime);
		if (myPlayer.transform.position == right.transform.position)
		{
			Shoot();
			myButton0.SetActive(true);
			myButton1.SetActive(true);
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
				bullet.transform.position = spawnPos.transform.position;
				bullet.transform.rotation = spawnPos.transform.rotation;
				bullet.SetActive(true);
			}
			m_FireCooldown = 0;
		}
		
	}
}