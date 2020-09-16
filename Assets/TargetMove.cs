using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMove : MonoBehaviour {

	public enum motionDirection { Spin, Horizontal, Vertical };
	public motionDirection motionState = motionDirection.Horizontal;

	public float spinSpeed = 180.0f;
	public float motionValue = 0.1f;

    void Update() {

		switch(motionState) {

			case motionDirection.Spin:
				gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
				break;

			case motionDirection.Horizontal:
				gameObject.transform.Translate(Vector3.right * Mathf.Cos(Time.timeSinceLevelLoad) * motionValue);
				break;

			case motionDirection.Vertical:
				gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionValue);
				break;
		}
    }
}
