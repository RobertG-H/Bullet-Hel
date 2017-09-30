using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public float SpaceShipSpeed = 2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		 //Vector2 PositionTransform = Vector2.zero;

		 if (Input.GetKey ("w")) {
			Debug.Log ("Player Moving Up");
			this.GetComponent<Rigidbody2D> ().velocity = Vector3.up * SpaceShipSpeed;
			//PositionTransform += -transform.forward * SpaceShipSpeed;
		}else if (Input.GetKey ("s")) {
			Debug.Log ("Player Moving Down");
			this.GetComponent<Rigidbody2D> ().velocity = Vector3.down * SpaceShipSpeed;
			//PositionTransform += transform.forward * SpaceShipSpeed;
		}

		else if (Input.GetKey ("a")) {
			Debug.Log ("Player Moving Left");
			this.GetComponent<Rigidbody2D> ().velocity = Vector3.left * SpaceShipSpeed;
			//PositionTransform += transform.right * SpaceShipSpeed;
		}else if (Input.GetKey ("d")) {
			Debug.Log ("Player Moving Right");
			this.GetComponent<Rigidbody2D> ().velocity = Vector3.right * SpaceShipSpeed;
			//PositionTransform += -transform.right * SpaceShipSpeed;
		} else {
			this.GetComponent<Rigidbody2D> ().velocity = Vector3.zero;
			//PositionTransform = transform.right * 0;
		}
		//this.GetComponent<Rigidbody2D> ().velocity = Vector3.right * SpaceShipSpeed;	
		//this.GetComponent<Rigidbody2D>().MovePosition += PositionTransform;
		/* bool Horizontal = Input.GetKey ("d") || Input.GetKey ("a");
		bool Vertical = Input.GetKey ("w") || Input.GetKey ("s");

		this.GetComponent<Rigidbody2D> ().velocity = Vector3 (Horizontal * SpaceShipSpeed, Vertical * SpaceShipSpeed, 0f); */
	}
}
