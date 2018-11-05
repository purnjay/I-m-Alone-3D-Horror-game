using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PixelImageEffect : MonoBehaviour {

	public Material effectMaterial;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnRenderImage(RenderTexture src, RenderTexture dst){
		Graphics.Blit (src, dst, effectMaterial);
	}
}
