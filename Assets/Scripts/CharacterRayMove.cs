using UnityEngine;
using System.Collections;

public class CharacterRayMove : MonoBehaviour {
	
	public float moveSpeed = 2f;
	public float turnSpeed = 90f;
	public float rotateSpeed = 10f;
	public float stopMovement = 0.2f;
	public Transform mark;
	
	CharacterController _cc;
	Transform _t;
	bool _isMoving = false;
	
	void Start()
	{
		_cc = GetComponent<CharacterController>();
		_t = transform;
		stopMovement = _cc.radius * 2.2f;
		mark.position = _t.position;
	}
	
	
	void Update () {
		
		if(Input.GetButtonDown ("Fire1"))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hitInfo;
			if(Physics.Raycast(ray, out hitInfo))
			{
				mark.position = hitInfo.point;
				_isMoving = true;
			}
		}
		
		if(_isMoving)
			MoveUtil.RotateTowards(_t, mark.position, rotateSpeed);
		
		Vector3 movement = _t.forward * moveSpeed;
		Vector3 dir = mark.position - _t.position;
		if(dir.sqrMagnitude > stopMovement * stopMovement)
		{
			_cc.SimpleMove(movement);
		} else {
			_isMoving = false;
			_cc.SimpleMove(mark.position - _t.position);
		}
	}

}





















