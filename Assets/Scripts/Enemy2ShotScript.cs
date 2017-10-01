using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2ShotScript : MonoBehaviour {

    public int Health;
	public float shotSpeed;
	// Use this for initialization
	void Start () {
        Health = 1;
	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<Rigidbody2D> ().MovePosition(this.GetComponent<Rigidbody2D> ().position + Vector2.down * shotSpeed);

        if(Health <= 0)
        {
            Destroy(gameObject);
        }
	}


	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.name == "BoundBoxBottom") {
			Destroy (gameObject);
		}
        if (coll.gameObject.name == "PlayerBullet" || coll.gameObject.name == "PlayerBullet(Clone)")
        {
            //Debug.Log("Bullet hit");
            Health--;
        }
    }	
}


