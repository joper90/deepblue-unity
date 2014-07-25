using UnityEngine;
using System.Collections;

public class quickMovement : MonoBehaviour {

	public float forceFactor = 25.0f;
	private Rigidbody2D controller;

	// Use this for initialization
	void Start () {
		controller = gameObject.GetComponent<Rigidbody2D> (); 
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey (KeyCode.UpArrow))
		{
			controller.AddForce(Vector3.up * Time.deltaTime * forceFactor);
		}

		if (Input.GetKey (KeyCode.RightArrow))
		{
			controller.AddForce(Vector3.right * Time.deltaTime * forceFactor);
		}

		if (Input.GetKey (KeyCode.LeftArrow))
		{
			controller.AddForce(Vector3.left * Time.deltaTime * forceFactor);
		}

		if (Input.GetKey (KeyCode.DownArrow))
		{
			controller.AddForce(Vector3.down * Time.deltaTime * forceFactor);
		}

	}
}
