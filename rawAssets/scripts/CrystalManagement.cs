using UnityEngine;
using System.Collections;

public class CrystalManagement : MonoBehaviour {

	public GameObject injectObject;

	private GameObject localObject;

	public static int crystalCount = 0;

	void OnBecameVisible()
	{
		//Add a crystal
		localObject = Instantiate(injectObject, transform.position, transform.rotation) as GameObject;
		localObject.transform.parent = transform;
		crystalCount ++;
	}

	void OnBecameInvisible()
	{
		Destroy (localObject);
		crystalCount --;
	}
}
