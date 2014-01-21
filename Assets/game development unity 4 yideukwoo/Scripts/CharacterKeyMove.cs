using UnityEngine;
using System.Collections;

public class CharacterKeyMove : MonoBehaviour {
	
	public float moveSpeed = 2f;
	public float turnSpeed = 90f;
	CharacterController _cc;
	
	void Start()
	{
		_cc = GetComponent<CharacterController>();	
	}
	
	void Update () {
		
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		
		_cc.Move(
			(transform.forward * v * moveSpeed + Physics.gravity.y * Vector3.up) * Time.deltaTime);
		transform.rotation *= Quaternion.Euler(0f, Time.deltaTime * turnSpeed * h, 0f);
	
	}
}
