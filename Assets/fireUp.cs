using UnityEngine;
using System.Collections;

public class fireUp : MonoBehaviour {

	public void FireUp(){
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (12,0);
	}
}
