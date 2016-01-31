using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Pooler : MonoBehaviour {

	public GameObject pooled;

	public int pooledAmount;

	List<GameObject> objects;

	// Use this for initialization
	void Start () {
		objects = new List<GameObject>();

		for(int i = 0; i < pooledAmount; i++){

			GameObject obj = (GameObject)Instantiate(pooled);
			obj.SetActive(false);

			objects.Add(obj);
		}
	}
	
	public GameObject getOne(){

		for (int i = 0; i < objects.Count; i++) {
			if (!objects [i].activeInHierarchy) {
				return objects [i];
			}
		}
			
			GameObject obj = (GameObject)Instantiate(pooled);
			obj.SetActive (false);
			objects.Add (obj);
			return obj;

	}
}
