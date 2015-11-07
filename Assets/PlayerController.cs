using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	void Update () {
		Move();
	}

	private void Move() {
		if (Input.GetKeyDown(KeyCode.UpArrow) && Physics2D.Raycast(transform.position, Vector2.up, 1).collider == null) {
			transform.position += Vector3.up;
		}
		
		if (Input.GetKeyDown(KeyCode.DownArrow) && Physics2D.Raycast(transform.position, -Vector2.up, 1).collider == null) {
			transform.position += Vector3.down;
		}
		
		if (Input.GetKeyDown(KeyCode.LeftArrow) && Physics2D.Raycast(transform.position, -Vector2.right, 1).collider == null) {
			transform.position += Vector3.left;
		}
		
		if (Input.GetKeyDown(KeyCode.RightArrow) && Physics2D.Raycast(transform.position, Vector2.right, 1).collider == null) {
			transform.position += Vector3.right;
		}
	}
}
