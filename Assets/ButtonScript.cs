using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {

	public int Health;
	public Sprite damagedSprite;
	bool pushable;
	// Use this for initialization
	void Start () {
		pushable = false;
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter2D(Collision2D coll){
		if (pushable) {
			if (coll.gameObject.name == "Spaceship")
			{
				Debug.Log("PUSAHGSIHDS");
				GameManager.gm.enemyDead(50);
			}
		}
		if (coll.gameObject.name == "PlayerBullet" || coll.gameObject.name == "PlayerBullet(Clone)")
		{
			
			Health--;
			if (Health < 1) {
				
				this.GetComponent<SpriteRenderer>().sprite = damagedSprite;
				pushable = true;
			}
		}

	}
}
