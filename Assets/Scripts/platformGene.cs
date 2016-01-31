using UnityEngine;
using System.Collections;

public class platformGene : MonoBehaviour {

	public GameObject waterPlat;
	public Transform genePoint;
	public float distance;

	private float waterPlatWidth;

	public Pooler thePool;

	// Use this for initialization
	void Start () {
		waterPlatWidth = waterPlat.GetComponent<BoxCollider2D> ().size.x;
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.x < genePoint.position.x) {
			transform.position = new Vector3(transform.position.x + waterPlatWidth + distance,transform.position.y,transform.position.z);

			//Instantiate(waterPlat, transform.position, transform.rotation);
			GameObject newPlat = thePool.getOne();
			newPlat.transform.position = transform.position;
			newPlat.transform.rotation = transform.rotation;
			newPlat.SetActive(true);
		}

	}
}
