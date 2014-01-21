using UnityEngine;
using System.Collections;

public class MoveUtil {

	public static void RotateTowards (Transform t, Vector3 dest, float rotateSpeed) {
		
		Vector3 dir = dest - t.position;
		if(dir == Vector3.zero)
			return;
		
		Quaternion rot = t.rotation;
		Quaternion toTarget = Quaternion.LookRotation (dir);
		
		rot = Quaternion.Slerp (rot,toTarget, rotateSpeed * Time.deltaTime);
		Vector3 euler = rot.eulerAngles;
		euler.z = 0;
		euler.x = 0;
		rot = Quaternion.Euler (euler);
		t.rotation = rot;
	}
	
}
