using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour {

	public bool GamePaused;
	public int Counter;
	// Use this for initialization
	void Start () {
		Counter = 0;
		GamePaused = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape) && Counter <= 0) {
			GamePaused = !GamePaused;
		
			if (GamePaused /* && Counter == 0 */) {
				//Counter = 60;
				Time.timeScale = 0;
				Counter = 60;
			}
			if (!GamePaused) {
				Counter = 60;
				Time.timeScale = 1;
			}
		}
        if (Counter > 0)
        {
            Counter--;
        }
	}
}
