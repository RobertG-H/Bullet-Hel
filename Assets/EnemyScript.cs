using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	public float EnemySpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<Rigidbody2D> ().velocity = Vector3.down * EnemySpeed;
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.name == "BoundBoxBottom") {
			Destroy (gameObject);
		}	
	}	

}
