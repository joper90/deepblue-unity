using UnityEngine;
using System.Collections;

public class playerSwap : MonoBehaviour {

	public GameObject man;
	public GameObject goop;

	private enum STATUS {MAN,GOOP};
	private STATUS currentStatus;

	// Use this for initialization
	void Start () {
		currentStatus = STATUS.MAN;
	}
	
	// Update is called once per frame
	void Update () {
		//Do we need to switch
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			if (currentStatus == STATUS.MAN)
			{
				//then we need to load goop
				Instantiate(goop, GameObject.FindGameObjectWithTag("man").transform.position, Quaternion.identity);
				GameObject.Destroy(GameObject.FindWithTag("man"));
				currentStatus = STATUS.GOOP;
			}else
			{
				Instantiate(man, GameObject.FindGameObjectWithTag("goop").transform.position, Quaternion.identity);
				GameObject.Destroy(GameObject.FindWithTag("goop"));
				currentStatus = STATUS.MAN;
			}
		}
	}
}
