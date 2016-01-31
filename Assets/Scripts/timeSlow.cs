using UnityEngine;
using System.Collections;

public class timeSlow : MonoBehaviour {

	public int duration = 2;
	private SpriteRenderer sprite;

	void Start(){

		sprite = GetComponent<SpriteRenderer> ();
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.name == "-player") {

			Time.timeScale = 0.5f;
			sprite.enabled = false;
			StartCoroutine(slowTime(duration));

		}
	}


	IEnumerator slowTime(int time){

		float pauseEndTime = Time.realtimeSinceStartup + time;
		while (Time.realtimeSinceStartup < pauseEndTime)
		{
			yield return 0;
		}

		Time.timeScale = 1;

	}
	
}
