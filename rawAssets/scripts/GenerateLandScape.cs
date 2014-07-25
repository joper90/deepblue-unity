using UnityEngine;
using System.Collections;

public class GenerateLandScape : MonoBehaviour {

	public GameObject injectObject = null; 
	public int	spawnCount = 10;

	// Use this for initialization
	void Start () {
	
		float currentPos = 0f;

		if (injectObject != null) 
		{
			for (int a=0; a < spawnCount; a++)
			{
				Vector3 newPos = new Vector3(currentPos,0,0);
				Instantiate(injectObject, newPos, transform.rotation);
				currentPos+=5.0f;
			}
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
