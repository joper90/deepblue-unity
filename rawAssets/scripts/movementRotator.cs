using UnityEngine;
using System.Collections;

public class movementRotator : MonoBehaviour {

	public float rotationSpeed;
	public float swimSpeed;
	public float maxSwimForward;


	private Animator _animator;
	//This is called in fixed update, as this stops any bouncing about.

	void Start()
	{
		this._animator = GetComponent<Animator>();
	}

	void FixedUpdate()
	{
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			rigidbody2D.angularVelocity = rotationSpeed;
		}
		else if (Input.GetKey (KeyCode.RightArrow))
		{
			rigidbody2D.angularVelocity = -rotationSpeed;
		}
		else //Stop rotation.
		{
			rigidbody2D.angularVelocity = 0.0f;
		}


		/*
		 * Limit the max swimSpeed.
		 */
		if (Input.GetKey(KeyCode.UpArrow))
		{
			rigidbody2D.velocity = Vector3.ClampMagnitude(rigidbody2D.velocity, maxSwimForward);
			rigidbody2D.AddForce(transform.up * 10);
		}

		if (Input.GetKey(KeyCode.DownArrow))
		{
			_animator.SetInteger("mode",1);
		}
	
	}
}
