using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;
	public Animator animator;
	public float runSpeed = 40f;
	public Joystick joystick;

	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;
	
	// Update is called once per frame
	void Update () {
		if (joystick.Horizontal >= .1f)
		{
			horizontalMove = runSpeed;
		}
		else if (joystick.Horizontal <= -.1f)
		{
			horizontalMove = -runSpeed;
		}
		else
		{
			horizontalMove = 0f;
		}

		float verticalMove = joystick.Vertical;
		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

		if (verticalMove <= -.5f)
		{
			crouch = true;
		}
		else
		{
			crouch = false;
		}

	}

	public void CharJump() {
		jump = true;
		animator.SetBool("IsJumping", true);
	}

	public void OnLanding() {
		animator.SetBool("IsJumping", false);
	}

	public void OnCrouching(bool isCrouching)
	{
		animator.SetBool("IsCrouching", isCrouching);
	}

	void OnCollisionStay(Collision collisionInfo)
	{
		Debug.Log(collisionInfo.gameObject.name);
		Debug.Log(collisionInfo);
	}

	void FixedUpdate ()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
	}
}
