using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformManager : MonoBehaviour
{
	public Transform[] playerTransforms;
	public int currentTransform;

	// Use this for initialization
	void Start ()
	{
		currentTransform = 1;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
