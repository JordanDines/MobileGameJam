using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureOffset : MonoBehaviour {

	private Renderer rend;
	private LevelMove lr;
	void Start(){
		lr = FindObjectOfType<LevelMove> ();
		rend = GetComponent<Renderer> ();
	}

	void Update () {
		Debug.Log (lr.m_fSpeed);
		float offset = Time.time * lr.m_fSpeed;
		rend.material.SetTextureOffset("_MainTex", new Vector3(0, (offset * .1f), 0));
	}
}
