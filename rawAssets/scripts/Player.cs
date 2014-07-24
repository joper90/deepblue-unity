using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed = 1f;
	public Vector2 maxVelocity = new Vector2(3, 5);
	public bool standing;
	public float jetSpeed = 15f;
	public float airSpeedMultiplier = .3f;
	

	void Start(){

		Vector2 test = new Vector2 (1, 2);
		float len = test.magnitude;
		Debug.Log ("Output : " + len);
		Vector2 nor = test.normalized;
		Debug.Log ("X:" + nor.x + " Y:" + nor.y);


		Vector2 upAngle = new Vector2 (1, 1000);
		Vector2 rightAngle = new Vector2 (5, 0);

		float angle = Vector2.Angle (rightAngle, upAngle);
		Debug.Log ("Difference angle = " + angle);

		float dot = Vector2.Dot (rightAngle, upAngle);
		Debug.Log ("Dot angle = " + dot);
	
	}

	
	// Update is called once per frame
	void FixedUpdate () {

		transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime ,0,0);

//		var forceX = 0f;
//		var forceY = 0f;
//
//		var absVelX = Mathf.Abs (rigidbody2D.velocity.x);
//		var absVelY = Mathf.Abs (rigidbody2D.velocity.y);
//
//
//		if (Input.GetKey ("right")) 
//		{
//			if (absVelY < .2f) 
//			{
//				forceX = speed * 1 * airSpeedMultiplier;
//			}
//		} else if (Input.GetKey ("left")) 
//		{
//			if (absVelY < .2f) 
//			{
//				forceX = speed * -1 * airSpeedMultiplier;	
//			}
//		} else
//		{
//			forceX = 0.0f;
//		}
//
//	
//		rigidbody2D.AddForce (new Vector2 (forceX, 0));
	}
}
