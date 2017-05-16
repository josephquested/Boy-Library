using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorMovement : MonoBehaviour {

	// SYSTEM //

	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}

	// INPUT //

	public void ReceiveMovementAxis (float horizontal, float vertical)
	{
		UpdateAnimator(horizontal, vertical);
		if (horizontal != 0 || vertical != 0)
		{
			Vector2 movement = GetMovementVector(horizontal, vertical);
			Move(movement);
		}
	}

	// MOVEMENT //

	Rigidbody2D rb;

	public float speed;

	void Move (Vector2 movement)
	{
		rb.AddForce(movement * speed, ForceMode2D.Impulse);
	}

	// ** REFACTOR TO HANDLE MULTIPLE BUTTON INPUT ** //
	Vector2 GetMovementVector (float horizontal, float vertical)
	{
		if (horizontal != 0 && vertical != 0)
		{
			if (horizontal > 0) return new Vector2(horizontal, 0);
			if (horizontal < 0) return new Vector2(horizontal, 0);
			if (vertical > 0) return new Vector2(0, vertical);
			if (vertical < 0) return new Vector2(0, vertical);
		}
		return new Vector2(horizontal, vertical);
	}

	// ANIMATOR //

	Animator anim;

	void UpdateAnimator (float horizontal, float vertical)
	{
		anim.SetBool("Moving", horizontal != 0 || vertical != 0);
	}
}
