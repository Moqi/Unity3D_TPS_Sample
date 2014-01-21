using UnityEngine;
using System.Collections;

public class CharacterKeyJumpMove : MonoBehaviour {
	
	public float moveSpeed = 10f;
	public float turnSpeed = 90f;
	public float jumpSpeed = 8f;
	public float fallSpeed = 20f;
	CharacterController _cc;
	Vector3 _move;
	
	void Start()
	{
		_cc = GetComponent<CharacterController>();	
	}
	
	void Update () {
		
		if(_cc.isGrounded)
		{
			float v = Input.GetAxis("Vertical");
			_move = transform.forward * v * moveSpeed;
		
			if(Input.GetButtonDown("Jump"))
			{
				_move += Vector3.up * jumpSpeed;
			}
		}
		
		_move += Vector3.down * fallSpeed * Time.deltaTime;
		_cc.Move(_move * Time.deltaTime);
		
		float h = Input.GetAxis("Horizontal");
		transform.rotation *= Quaternion.Euler(0f, Time.deltaTime * turnSpeed * h, 0f);
	
	}
}
