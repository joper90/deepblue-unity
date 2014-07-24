using UnityEngine;
using System.Collections;

public class drop : MonoBehaviour {

	public 

	// Update is called once per frame
	void FixedUpdate () {
		transform.Translate(Vector3.down * Time.deltaTime);

	}
}
