using System.Collections;
using System.Collections.Generic;
using UnityEngine;
enum ObjectType {
    Cube, Ball, Door
}
public class ObjectInfo : MonoBehaviour {
    [SerializeField]
    ObjectType type;
    InteractionBehaviour[] behaviours;
    private void Start() {
        behaviours = GetComponents<InteractionBehaviour>();
    }
    public void Activate () {
        for (int i = 0; i < behaviours.Length; i++) {
            behaviours[i].Activate();
        }
        Debug.Log("Info Activated");
	}
}
