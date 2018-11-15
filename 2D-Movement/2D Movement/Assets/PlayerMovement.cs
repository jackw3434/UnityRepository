using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;
	public Animator animator;
	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;

    protected Joystick joystick;
    protected Joybutton joybutton;

    private void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<Joybutton>();
    }


    // Update is called once per frame
    void Update () {

        var rigidbody = GetComponent<Rigidbody2D>();        
     
            rigidbody.velocity = new Vector3(joystick.Horizontal * 10f,
            rigidbody.velocity.y,
            joystick.Vertical * 10f);

       

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
     
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
			animator.SetBool("IsJumping", true);
		}

		if (Input.GetButtonDown("Crouch"))
		{
			crouch = true;
		} else if (Input.GetButtonUp("Crouch"))
		{
			crouch = false;
		}

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
