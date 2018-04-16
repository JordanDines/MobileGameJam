using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	int playerPos = 1;
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
	void Awake()
	{
		
	}

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(isMovingLeft == true)
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

			isMovingLeft = false;
			myButton1.SetActive(true);
			myButton2.SetActive(true);
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
			isMovingMid = false;
			myButton0.SetActive(true);
			myButton2.SetActive(true);
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
			isMovingRight = false;
			myButton0.SetActive(true);
			myButton1.SetActive(true);
		}
	}
}