using UnityEngine;
using System.Collections;

public class GroundReshaper : MonoBehaviour {

	private float reshapingSpeed;
	private bool reshapingByX;
	private bool growing = false;

	private const float minBound = 0f;
	private const float maxBound = 1f;

	private float startOfLastReshaping;

	void Start () {
		reshapingSpeed = Random.Range (10, 50);
		reshapingByX = Random.Range (0, 2) == 0;
		startOfLastReshaping = - Random.Range(0, 10) / 10f;
	}

	void Update () {
		
		float scaleX = transform.localScale.x;
		float scaleY = transform.localScale.y;

		if (reshapingByX) {
			if (growing) {
				if (scaleX < 0.99) {
					scaleX = Mathf.Lerp(scaleX, 1f, (Time.time - startOfLastReshaping) * (reshapingSpeed / 1000f));
				} else {
					scaleX = 1;
					growing = false;
					reshapingByX = false;
					startOfLastReshaping = Time.time;
				}
			} else {
				if (scaleX > 0.01) {
					scaleX = Mathf.Lerp(scaleX, 0f, (Time.time - startOfLastReshaping) * (reshapingSpeed / 1000f));
				} else {
					scaleX = 1;
					scaleY = 0;
					growing = true;
					reshapingByX = false;
					startOfLastReshaping = Time.time;
				}
			}
		} else {
			if (growing) {
				if (scaleY < 0.99) {
					scaleY = Mathf.Lerp(scaleY, 1f, (Time.time - startOfLastReshaping) * (reshapingSpeed / 1000f));
				} else {
					scaleY = 1;
					growing = false;
					reshapingByX = true;
					startOfLastReshaping = Time.time;
				}
			} else {
				if (scaleY > 0.01) {
					scaleY = Mathf.Lerp(scaleY, 0f, (Time.time - startOfLastReshaping) * (reshapingSpeed / 1000f));
				} else {
					scaleY = 1;
					scaleX = 0;
					growing = true;
					reshapingByX = true;
					startOfLastReshaping = Time.time;
				}
			}
		}

		transform.localScale = new Vector3(scaleX, scaleY, transform.localScale.z);
	}
}
