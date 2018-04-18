using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformManager : MonoBehaviour
{
	public Transform[] playerTransforms;
	public int currentTransform;

	public PlayerMovement pm;

	// Use this for initialization
	void Start ()
	{
		currentTransform = 1;	
	}
	
	// Update is called once per frame
	void Update () {
		if (pm.m_FireCooldown < pm.m_FireRate){
			pm.m_FireCooldown += Time.deltaTime;
			pm.readyCrossbow.SetActive (false);
			pm.shotCrossbow.SetActive (true);
		}
		else {
			pm.m_FireCooldown = pm.m_FireCooldown;
			pm.readyCrossbow.SetActive (true);
			pm.shotCrossbow.SetActive (false);
		} 
		
	}
}
