using UnityEngine;
using System.Collections;

public class boatAction : MonoBehaviour {

	public GameObject boatTrigger;
	public GameObject boatFront;

	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D target)
	{
		Debug.Log ("Entered the Boat");
	}

	void OnTriggerExit2D(Collider2D target)
	{
		Debug.Log ("Left the Boat");
	}

}
