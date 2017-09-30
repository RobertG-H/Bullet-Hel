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

		 Vector2 PositionTransform = Vector2.zero;

		 if (Input.GetKey ("w")) {
			Debug.Log ("Player Moving Up");
			//this.GetComponent<Rigidbody2D> ().velocity = Vector3.up * SpaceShipSpeed;
			PositionTransform += Vector2.up * SpaceShipSpeed;
		}else if (Input.GetKey ("s")) {
			Debug.Log ("Player Moving Down");
			//this.GetComponent<Rigidbody2D> ().velocity = Vector3.down * SpaceShipSpeed;
			PositionTransform += Vector2.down * SpaceShipSpeed;
		}

		if (Input.GetKey ("d")) {
			Debug.Log ("Player Moving Right");
			//this.GetComponent<Rigidbody2D> ().velocity = Vector3.right * SpaceShipSpeed;
			PositionTransform += Vector2.right * SpaceShipSpeed;
		}
		else if (Input.GetKey ("a")) {
			Debug.Log ("Player Moving Left");
			//this.GetComponent<Rigidbody2D> ().velocity = Vector3.left * SpaceShipSpeed;
			PositionTransform += Vector2.left * SpaceShipSpeed;
		}
	
		if (Input.GetKey(KeyCode.None)) {
			//this.GetComponent<Rigidbody2D> ().velocity = Vector3.zero;
			PositionTransform = Vector2.zero;
		}
// <<<<<<< HEAD
		//this.GetComponent<Rigidbody2D> ().velocity = Vector3.right * SpaceShipSpeed;	
		//this.GetComponent<Rigidbody2D>().MovePosition += PositionTransform;
		/* bool Horizontal = Input.GetKey ("d") || Input.GetKey ("a");
		bool Vertical = Input.GetKey ("w") || Input.GetKey ("s"); */

		this.GetComponent<Rigidbody2D> ().MovePosition (this.GetComponent<Rigidbody2D> ().position + PositionTransform);
//=======
        
		
//>>>>>>> 5436e28eaf30d1c85d57fce50a1e3f2c53db060d
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
		if (collision.gameObject.name == "Enemy1(Clone)")
        {
            Debug.Log("CONTACT");
            Destroy(gameObject);
            GameManager.gm.gameIsOver = true;
        }
    }
}
