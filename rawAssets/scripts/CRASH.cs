using UnityEngine;
using System.Collections;

public class CRASH : MonoBehaviour {

	private int count  = 0;
	private bool mouseShown = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (Input.GetKeyUp(KeyCode.A))
		{
			if (mouseShown)
			{
				Screen.showCursor = false;
				mouseShown = false;
				Debug.Log("KeyPressed - hide Mouse");
			}
			else
			{
				Screen.showCursor = true;
				mouseShown = true;
				Debug.Log("KeyPressed - Show mounse");
			}
		}


	}

	void OnCollisionEnter2D(Collision2D other)
	{
		Debug.Log("CRASHED" + count++);
	}

}
