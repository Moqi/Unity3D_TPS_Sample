using UnityEngine;
using System.Collections;

public class CameraRig : MonoBehaviour {
	
	public Transform target;
	
	void LateUpdate () {
		transform.position = Vector3.Lerp(
			transform.position,
			target.position,
			Time.deltaTime);
	}
}
