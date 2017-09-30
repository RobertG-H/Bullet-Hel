using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2ShotScript : MonoBehaviour {


	public float shotSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<Rigidbody2D> ().MovePosition(this.GetComponent<Rigidbody2D> ().position + Vector2.down * shotSpeed) ;
	}


	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.name == "BoundBoxBottom") {
			Destroy (gameObject);
		}	
	}	
}


