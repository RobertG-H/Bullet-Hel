using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {

	public GameObject enemy1;
	public GameObject playerBase;
	float randX;
	Vector2 whereToSpawn;
	public float spawnRate = 2f;
	float nextSpawn = 0.0f;




	void Update(){


		if (Time.time > nextSpawn) {
			nextSpawn = Time.time + spawnRate;
			randX = Random.Range (-5, 3);
			whereToSpawn = new Vector2 (randX, transform.position.y);

			GameObject enemy = (GameObject)Instantiate (enemy1, whereToSpawn, transform.rotation);
		}

	}
}
