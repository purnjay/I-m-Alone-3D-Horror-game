using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {

	//Vector
	//Mouse Direction
	private Vector2 mouseDirection;

	private Transform myBody;

	//Int
	[Range(2,6)]
	public int mouseSenstivity = 1;

	//Float
	private 

	// Use this for initialization
	void Start () {
		myBody = this.transform.parent.transform;
	}
	
	// Update is called once per frame
	void Update () {

		Cursor.lockState = CursorLockMode.Locked;

		//How Much the mouse is moved? will be asked every frame.

		Vector2 mouseChange = new Vector2(Input.GetAxisRaw ("Mouse X"),
			                              Input.GetAxisRaw("Mouse Y"));
		mouseDirection += mouseChange * mouseSenstivity;

		//Limits the Y view of Player.
		float rot = Mathf.Clamp (-mouseDirection.y, -36, 36);

		this.transform.localRotation =  Quaternion.AngleAxis(rot, Vector3.right);

		myBody.localRotation = Quaternion.AngleAxis (mouseDirection.x, Vector3.up);

	
	}
}
