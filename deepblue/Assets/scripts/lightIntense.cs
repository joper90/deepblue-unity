using UnityEngine;
using System.Collections;

public class lightIntense : MonoBehaviour {


	public float duration = 1.0F;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float phi = Time.time / duration * 2 * Mathf.PI;
		float amplitude = Mathf.Cos(phi) * 0.5F + 0.5F;
		light.intensity = amplitude;
	}
}
