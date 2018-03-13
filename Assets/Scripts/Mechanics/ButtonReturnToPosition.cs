using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class ButtonReturnToPosition : MonoBehaviour {

	bool _retractButton;
	Vector3 originPosition;
	public LinearMapping _linearMapping;
	LinearDriveCallback _linearDrive;

	public float retractSpeed = 0.5f;

	void Start () {
		originPosition = transform.position;
		_linearDrive = GetComponent<LinearDriveCallback> ();
	}

	void Update () {

	}

	public void RetractNow (bool _retract) {
		_retractButton = _retract;
	}

	void LateUpdate () {
		if (_retractButton) {
			_linearMapping.value -= Time.deltaTime * retractSpeed;
			if (_linearMapping.value > 0.05f) {
				// Debug.Log ("Retracting Button");
				transform.position = Vector3.Lerp (_linearDrive.startPosition.position, _linearDrive.endPosition.position, _linearMapping.value);
			} else {
				// Debug.Log ("Snapping Button");
				transform.position = _linearDrive.startPosition.position;
				_linearMapping.value = 0;
				_retractButton = false;
			}
		}
	}
}