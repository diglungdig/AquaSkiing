using UnityEngine;
using System.Collections;

public class CharacterControl : MonoBehaviour {

	public float jumpforce;
	public float movespeed;

	private bool jumped = false;
	public LayerMask waterLayer;

	private Rigidbody2D playerRigid;
	private Collider2D playerCollider;

	private Animator anim;

	public GameObject breakpoint;
	public GameObject ship;

	// Use this for initialization
	void Start () {
		playerRigid = gameObject.GetComponent<Rigidbody2D> ();
		playerCollider = gameObject.GetComponent<Collider2D> ();
		anim = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		jumped = !Physics2D.IsTouchingLayers (playerCollider, waterLayer);
		anim.SetBool ("isInAir", jumped);

		playerRigid.velocity = new Vector2 (movespeed, playerRigid.velocity.y);

		if (Input.GetKeyDown (KeyCode.Space)) {
			if(!jumped){
				playerRigid.velocity = new Vector2(playerRigid.velocity.x, jumpforce);
			}
		}
	}


	public void speedItemBoost(float boostValue, float duration){
		//movespeed = movespeed * boostValue; 
		StartCoroutine (speedBoost (boostValue, duration));
	}


	IEnumerator speedBoost(float value, float time){
		float temp = movespeed;
		movespeed = movespeed * value;
		yield return new WaitForSeconds(time);
		movespeed = temp;
	}

	void OnCollisionEnter2D (Collision2D sth){
		if (sth.gameObject.tag == "obstacles") {
			breaking ();
		}

	}

	void breaking(){
		ship.SendMessage("FireUp");
		playerRigid.constraints = RigidbodyConstraints2D.None;
		breakpoint.GetComponent<Breakable>().breakAngle = 0;
		StartCoroutine (speedDecline());
	}

	IEnumerator speedDecline(){
		while (movespeed > 0.01) {
			movespeed = movespeed - Time.deltaTime*2;
			yield return null;
		}
	}
}
