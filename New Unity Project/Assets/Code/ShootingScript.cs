using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour {

	[SerializeField]
	public GameObject m_Player;
	[SerializeField]
	public GameObject m_CrossBowBoltPrefab;
	[SerializeField]
	public Transform spawnPos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void Shoot()
	{
		Vector3 fwd = m_Player.transform.TransformDirection(Vector3.forward);

		if(Physics.Raycast(m_Player.transform.position, fwd, 10))
		{
			GameObject CrossBowBolt = (GameObject)Instantiate(m_CrossBowBoltPrefab, spawnPos.position, transform.rotation);
		}
	}
}
