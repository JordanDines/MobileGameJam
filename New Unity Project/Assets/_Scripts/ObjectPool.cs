using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ObjectPoolItem
{
  public int amountToPool;
  public GameObject objectToPool;
  public bool shouldExpand;
}

public class ObjectPool : MonoBehaviour
{

	public List<ObjectPoolItem> itemsToPool;
	public static ObjectPool SharedInstance;
	public bool shouldExpand;
	public List<GameObject> pooledObjects;
	private GameObject objectToPool;

	// Use this for initialization
	void Awake () {
		SharedInstance = this;
	}

	void Start()
	{
		pooledObjects = new List<GameObject>();
		foreach (ObjectPoolItem item in itemsToPool)
		{
			for (int i = 0; i < item.amountToPool; i++)
			{
				GameObject obj = (GameObject)Instantiate(item.objectToPool);
				obj.SetActive(false);
				pooledObjects.Add(obj);
			}
		}
	}

	public GameObject GetPooledObject(string tag)
	{
		for (int i = 0; i < pooledObjects.Count; i++)
		{
			if (!pooledObjects[i].activeInHierarchy && pooledObjects[i].tag == tag)
			{
				return pooledObjects[i];
			}
		}
		foreach (ObjectPoolItem item in itemsToPool)
		{
			if (item.objectToPool.tag == tag)
			{
				if (item.shouldExpand)
				{
					GameObject obj = (GameObject)Instantiate(item.objectToPool);
					obj.SetActive(false);
					pooledObjects.Add(obj);
					return obj;
				}
			}
		}
		if (shouldExpand)
		{
			GameObject obj = (GameObject)Instantiate(objectToPool);
			obj.SetActive(false);
			pooledObjects.Add(obj);
			return obj;
		}
		else
		{
			return null;
		};
	}
}
