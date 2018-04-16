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
	[SerializeField]
	public float m_FireRate;
	private float m_FireCooldown;
	// Use this for initialization
	void Start () {
		m_FireCooldown = m_FireRate;
	}
	
	// Update is called once per frame
	void Update () {
		m_FireCooldown += Time.deltaTime;
	}

	public void Shoot()
	{
		Vector3 fwd = m_Player.transform.TransformDirection(Vector3.forward);

		if(Physics.Raycast(m_Player.transform.position, fwd, 10))
		{
			if (m_FireCooldown >= m_FireRate)
			{
				GameObject bullet = ObjectPool.SharedInstance.GetPooledObject();
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
}
