using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			transform.position += Vector3.up;
		}
		if (Input.GetKeyDown(KeyCode.DownArrow)) {
			transform.position += Vector3.down;
		}
		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			transform.position += Vector3.left;
		}
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			transform.position += Vector3.right;
		}
	}
}
