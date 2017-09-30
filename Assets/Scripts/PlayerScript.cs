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
		if (Input.GetKey ("w")) {
			Debug.Log ("Player Moving Up");
			this.GetComponent<Rigidbody2D> ().velocity = Vector3.up * SpaceShipSpeed;
		}
		else if (Input.GetKey ("a")) {
			Debug.Log ("Player Moving Left");
			this.GetComponent<Rigidbody2D> ().velocity = Vector3.left * SpaceShipSpeed;
		}else if (Input.GetKey ("s")) {
			Debug.Log ("Player Moving Down");
			this.GetComponent<Rigidbody2D> ().velocity = Vector3.down * SpaceShipSpeed;
		}else if (Input.GetKey ("d")) {
			Debug.Log ("Player Moving Right");
			this.GetComponent<Rigidbody2D> ().velocity = Vector3.right * SpaceShipSpeed;
		} else {
			this.GetComponent<Rigidbody2D> ().velocity = Vector3.zero;
		}
        
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Enemy1")
        {
            Debug.Log("CONTACT");
            Destroy(collision.gameObject);
        }
    }
}
