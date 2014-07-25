using UnityEngine;
using System.Collections;

public class clamScript : MonoBehaviour {

	public GameObject pearlObject;
	private bool isOpen = true;
	private bool pearlTaken = false;



	// Use this for initialization
	void Start () {
	
		isOpen = true;
		pearlTaken = false;

		//Create the pearl in the clam.
		Vector3 newPos = new Vector3(0,0,0);
		Instantiate(pearlObject, newPos, transform.rotation);

	}

	public void setOpen()
	{
		isOpen = true;
		Debug.Log ("Clam is set to open..");
	}

	public void setClosed()
	{
		isOpen = false;
		Debug.Log ("Clam is now closed..");
	}

	void OnTriggerEnter2D(Collider2D target)
	{
		Debug.Log ("Clam Hit....");
		if (!isOpen) {
			Debug.Log ("Player died");
		}
	}
}
