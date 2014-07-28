using UnityEngine;
using System.Collections;

public class RotateAroundPoint : MonoBehaviour {

	public float amountAppear = 1f;
	public float amountDisappear = -1f;

	private float startAngle = 270f;
	private float uprightAngle = 340f;

	private float currentAngle = 270f;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{

		currentAngle = transform.eulerAngles.z;

		if (Input.GetKey (KeyCode.Space))
	    {
			if (currentAngle < uprightAngle)
			{
				transform.Rotate (0,  0, amountAppear * Time.deltaTime);
			}

		}
		else
		{
			if (currentAngle > startAngle)
			{
				transform.Rotate (0,  0, amountDisappear * Time.deltaTime);
			}
		}
		
	}
}
