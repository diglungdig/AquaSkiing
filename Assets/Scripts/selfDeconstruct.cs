using UnityEngine;
using System.Collections;

public class selfDeconstruct : MonoBehaviour {

	public GameObject deconstructPoint;

	// Use this for initialization
	void Start () {
		deconstructPoint = GameObject.Find ("DeconstructPoint");
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < deconstructPoint.transform.position.x) {
			//Destroy(gameObject);

			gameObject.SetActive(false);
		}
	}
}
