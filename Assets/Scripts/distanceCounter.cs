using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class distanceCounter : MonoBehaviour {

	private long count = 0;
	public Text num;

	// Use this for initialization
	
	// Update is called once per frame
	void Update () {

		count = count + (long) Mathf.Round((Time.deltaTime * 50));
		Debug.Log (count);
		num.text = count.ToString();

	}
}
