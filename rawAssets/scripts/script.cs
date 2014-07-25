using UnityEngine;
using System.Collections;

public class script : MonoBehaviour {

	public GameObject crystal;

	// Use this for initialization
	void Start () {
	
		Instantiate (crystal, transform.position, Quaternion.identity);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
