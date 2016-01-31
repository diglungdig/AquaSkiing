using UnityEngine;
using System.Collections;

public class speedUp : MonoBehaviour {

	public float multifier;
	public float duration;
	public CharacterControl player;
	

	void OnTriggerEnter2D(Collider2D other){
		if (other.name == "-player") {
			player.speedItemBoost (multifier, duration);

			gameObject.SetActive (false);
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
