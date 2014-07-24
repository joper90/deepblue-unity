using UnityEngine;
using System.Collections;

public class scoller : MonoBehaviour {

	public float speed  =  0;
	private float pos = 0;
	private bool work = false;
	// Use this for initialization
	void Start () {
	}

	public void gogogo()
	{
		work = true;
	}

	// Update is called once per frame
	void Update () {

		if (work) {
						pos += speed;
						if (pos > 1.0f)
								pos -= 1.0f;

						renderer.material.mainTextureOffset = new Vector2 (pos, 0);
				}

	}
}
