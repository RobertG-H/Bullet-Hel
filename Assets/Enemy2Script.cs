using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Script : MonoBehaviour {

	public GameObject enemy2Shot;
	public float EnemySpeed;
	private float movement;
	float shootTimer;
	float nextShot;
	float turnTimer;
	float nextTurn = 0.0f;
	bool facingRight;


	// Use this for initialization
	void Start () {
		facingRight = true;
		movement = 1.5f;
		turnTimer = 2f;
		shootTimer = .3f;
	}
	
	// Update is called once per frame
	void Update () {
		//Shoot timer
		if (Time.time > nextShot) {
			nextShot = Time.time + shootTimer;
			Shoot ();
		}

		// Turn timer
		if (Time.time > nextTurn) {
			nextTurn = Time.time + turnTimer;
			if (facingRight) {
				facingRight = false;
				movement = -1.5f;
			}
			else{
				facingRight = true;	
				movement = 1.5f;
			}

		}

		//10.26 is the y position of enemy2
		this.GetComponent<Rigidbody2D> ().MovePosition(new Vector2 (this.GetComponent<Rigidbody2D> ().position.x + movement* EnemySpeed, 10.26f) );
	}

	void Shoot(){
		GameObject shot = (GameObject)Instantiate (enemy2Shot, transform.position, transform.rotation);
	
	}
}
