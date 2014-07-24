using UnityEngine;
using System.Collections;

public class swimMovement : MonoBehaviour {
	
	public float rotationSpeed;
	public float jetSpeed;
	public float maxForward;
	
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
			//rigidbody2D.angularVelocity = 0.0f;
		}
		
		if (Input.GetKey(KeyCode.UpArrow))
		{
			rigidbody2D.velocity = Vector3.ClampMagnitude(rigidbody2D.velocity, maxForward);
			rigidbody2D.AddForce(transform.up * jetSpeed);
		}

		//if (rigidbody.velocity.y > maxVelocity)
		//	rigidbody.velocity.x = maxVelocity;
		
	}
}