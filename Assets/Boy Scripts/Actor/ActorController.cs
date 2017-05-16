using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorController : MonoBehaviour {

	// SYSTEM //

	void Start ()
	{
		movement = GetComponent<ActorMovement>();
	}

	// INPUT //

	ActorMovement movement;

	public void ReceiveMovementAxis (float horizontal, float vertical)
	{
		movement.ReceiveMovementAxis(horizontal, vertical);
	}
}
