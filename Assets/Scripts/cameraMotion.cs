using UnityEngine;
using System.Collections;

public class cameraMotion : MonoBehaviour {

	public GameObject player;

	private Vector3 pos;
	private float distanceBetween;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("-player");
		pos = player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		distanceBetween = player.transform.position.x - pos.x;
		transform.position = new Vector3 (transform.position.x + distanceBetween, transform.position.y, transform.position.z);
		pos = player.transform.position;
	}
}
