using UnityEngine;
using System.Collections;

public class runScrooler : MonoBehaviour {

	public scoller myS;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D target)
	{ 
		Debug.Log ("Im hit! " + target.name);
		myS.gogogo();
	}
}
