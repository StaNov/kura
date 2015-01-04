using UnityEngine;
using System.Collections;

public class GroundReshaper : MonoBehaviour {

	private float reshapingSpeed;
	private bool reshapingByX;
	private bool growing = false;

	private const float minBound = 0f;
	private const float maxBound = 1f;

	private float startOfLastReshaping = 0;

	void Start () {
		reshapingSpeed = Random.Range (10, 200);
		reshapingByX = Random.Range (0, 100) >= 50;
	}

	void Update () {
		
		float scaleX = transform.localScale.x;
		float scaleY = transform.localScale.y;

		if (reshapingByX) {
			if (growing) {
				if (transform.localScale.x < 0.99) {
					scaleX = Mathf.Lerp(transform.localScale.x, 1f, Time.time * (reshapingSpeed / 1000f) - startOfLastReshaping);
				} else {
					scaleX = 1;
					growing = false;
					startOfLastReshaping = Time.time;
				}
			} else {
				if (transform.localScale.x > 0.01) {
					scaleX = Mathf.Lerp(transform.localScale.x, 0f, Time.time * (reshapingSpeed / 1000f) - startOfLastReshaping);
				} else {
					scaleX = 1;
					growing = true;
					reshapingByX = false;
					startOfLastReshaping = Time.time;
				}
			}
		} else {
			if (growing) {
				if (transform.localScale.y < 0.99) {
					scaleY = Mathf.Lerp(transform.localScale.y, 1f, Time.time * (reshapingSpeed / 1000f) - startOfLastReshaping);
				} else {
					scaleY = 1;
					growing = false;
					startOfLastReshaping = Time.time;
				}
			} else {
				if (transform.localScale.y > 0.01) {
					scaleY = Mathf.Lerp(transform.localScale.y, 0f, Time.time * (reshapingSpeed / 1000f) - startOfLastReshaping);
				} else {
					scaleY = 1;
					growing = true;
					reshapingByX = true;
					startOfLastReshaping = Time.time;
				}
			}
		}

		transform.localScale = new Vector3(scaleX, scaleY, transform.localScale.z);
	}
}
