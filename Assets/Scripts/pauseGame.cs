using UnityEngine;
using System.Collections;

public class pauseGame : MonoBehaviour {

	public GameObject panel;

	// Use this for initialization


	public void EnablePause(){

		panel.SetActive (true);
		Time.timeScale = 0f;
	}

	public void EnableResume(){
		panel.SetActive (false);
		Time.timeScale = 1.0f;
	}

	// Update is called once per frame
	void Update () {
	
	}
}
