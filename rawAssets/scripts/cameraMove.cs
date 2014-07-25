using UnityEngine;
using System.Collections;

public class cameraMove : MonoBehaviour {

	public float speed = 30f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

			Vector3 tmp = new Vector3(speed *Time.deltaTime,0,0);
			transform.position += tmp;


	}
}
