using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorSystem : MonoBehaviour {

	//Float

	public float speed;
	private float angle;

	//Vectors
	private Vector3 direction;

	//Bool
	bool playerInSight;
	bool doorOpen;

	//Layer
	[SerializeField]
	LayerMask player;

	//Text
	public Text infoText;

	// Use this for initialization
	void Start () {
		playerInSight = false;
		doorOpen = false;
		angle = transform.eulerAngles.y;
	}
	
	// Update is called once per frame
	void Update () {
		if(Mathf.Round(transform.eulerAngles.y) != angle){
			transform.Rotate (direction * speed);
		}

		playerInSight = Physics.CheckSphere (this.transform.position, 0.9f, player);

		if (!playerInSight) {
			infoText.text = "";
		}

		if (playerInSight && !doorOpen) {
			infoText.text = "Press E to Open.";
		}else if(playerInSight && doorOpen){
			infoText.text = "Press E to Close.";
		}

		if (playerInSight && Input.GetKeyDown (KeyCode.E) && !doorOpen) {
			angle = 90;
			doorOpen = true;
			direction = Vector3.up;
		}else if(playerInSight && Input.GetKeyDown (KeyCode.E) && doorOpen){
			angle = 0;
			doorOpen = false;
			direction = -Vector3.up;
		}

	}
}
