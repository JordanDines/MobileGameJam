using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	private bool tap;
	private Vector2 startTouch;
	private int playerMove = 15;
	int playerPos = 1;
	public GameObject myPlayer;
	Vector3 middlePos = Vector3.zero;
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

	}
	public void leftButton()
	{
		playerPos = 0;
		myPlayer.transform.position = new Vector3 (-playerMove, 2.5f, 0);
	}
	public void middleButton()
	{
		playerPos = 1;
		myPlayer.transform.position = new Vector3(0, 2.5f, 0);
	}
	public void rightButton()
	{
		playerPos = 2;
		myPlayer.transform.position = new Vector3(playerMove, 2.5f, 0);
	}


}
