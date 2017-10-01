using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public float SpaceShipSpeed = 2;
	public GameObject PlayerShot;
	public int Counter;
	//public Sprite turnLeftSprite;
	// Use this for initialization


    // Use this for initialization
    void Start () {
			Counter = 0;
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
		//	this.GetComponent<SpriteRenderer>().sprite = turnLeftSprite;
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

        if(Input.GetKey("up") && Counter <= 0)
        {
            Counter = 20;
            Debug.Log("Player shooting");
            PlayerShoot();
        }

        if (Counter > 0)
        {
            Counter--;
        }
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
		if (collision.gameObject.name == "Enemy2 Shot(Clone)")
		{
			Debug.Log("CONTACT");
			Destroy(gameObject);
			GameManager.gm.gameIsOver = true;
		}
    }

    void PlayerShoot()
    {
        GameObject shot = (GameObject)Instantiate(PlayerShot, transform.position, transform.rotation);

    }

}
