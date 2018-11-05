using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadBob : MonoBehaviour {

	//Floats
	private float timer = 0.0f;

	public float bobbingSpeed = 0.2f;
	public float bobbingAmount = 0.08f;
	public float midpoint = 1.0f;


	// Update is called once per frame
	void Update () {

		float waveslice = 0.0f;
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");

		if (Mathf.Abs (horizontal) == 0 && Mathf.Abs (vertical) == 0) {
			timer = 0.0f;
		} else {
			waveslice = Mathf.Sin (timer);
			timer = timer + bobbingSpeed;
			if (timer > Mathf.PI * 2) {
				timer = timer - (Mathf.PI * 2);
			}
		}

		if (waveslice != 0) {
			
			float translateChange = waveslice * bobbingAmount;
			float totalAxes = Mathf.Abs (horizontal) + Mathf.Abs (vertical);
			totalAxes = Mathf.Clamp (totalAxes, 0.0f, 1.0f);
			translateChange = totalAxes * translateChange;
			transform.localPosition = new Vector3(0, midpoint + translateChange, 0);
		
		} else {
			transform.localPosition = new Vector3(0, midpoint, 0);
		}
	}
}
