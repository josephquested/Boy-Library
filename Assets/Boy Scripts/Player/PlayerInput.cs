using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

	// SYSTEM //

	void Start ()
	{
		controller = GetComponent<ActorController>();
	}

	void FixedUpdate ()
	{
		UpdateMovement();
	}

	// MOVEMENT //

	ActorController controller;

	void UpdateMovement ()
	{
		controller.ReceiveMovementAxis(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
	}
}
