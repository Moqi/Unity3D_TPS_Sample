using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	void OnTriggerEnter(Collider c)
	{
		Destroy(gameObject);
	}

}
