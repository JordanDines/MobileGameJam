using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureOffset : MonoBehaviour {

	public float scrollSpeed = 0.5f;
	public Renderer rend;

	void Start(){
		rend = GetComponent<Renderer> ();
	}

	void Update () {
		float offset = Time.time * scrollSpeed;
		rend.material.SetTextureOffset("_MainTex", new Vector3(0, offset, 0));
	}
}
