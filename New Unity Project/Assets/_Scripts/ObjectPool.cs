using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour {

	public static ObjectPool SharedInstance;
	public List<GameObject> pooledObjects;
	public GameObject objectToPool;
	public int amountToPool;

	// Use this for initialization
	void Awake () {
		SharedInstance = this;
	}

	private void Start()
	{
		pooledObjects = new List<GameObject>();
		for (int i = 0; i < amountToPool; i++)
		{
			GameObject obj = (GameObject)Instantiate(objectToPool);
			obj.SetActive(false);
			pooledObjects.Add(obj);
		}
	}

	public GameObject GetPooledObject()
	{
		for (int i = 0; i < pooledObjects.Count; i++)
		{
			if (!pooledObjects[i].activeInHierarchy)
			{
				return pooledObjects[i];
			}
		}
		return null;
	}
}
