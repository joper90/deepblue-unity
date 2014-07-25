using UnityEngine;
using System.Collections;

public class boatOpened : MonoBehaviour {


	public GameObject boatFrontSprite;
	public Renderer boatBackSprite;

	// Use this for initialization
	void Start () {
		boatBackSprite.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D target)
	{
		Debug.Log ("Entered the Boat2");
		boatFrontSprite.renderer.enabled = false;
		boatBackSprite.enabled = true;
	}
	
	void OnTriggerExit2D(Collider2D target)
	{
		Debug.Log ("Left the Boat2");
		boatFrontSprite.renderer.enabled = true;
		boatBackSprite.enabled = false;
	}
}
