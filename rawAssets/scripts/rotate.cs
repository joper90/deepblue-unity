using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	public float amount = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		transform.Rotate (0, amount, 0);

	}
}
