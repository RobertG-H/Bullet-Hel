using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

    // make game manager public static so can access this from other scripts
    public static GameManager gm;

    // public variables

    public int score = 0;

    public bool gameIsOver = false;

    public bool canBeatLevel = true;

    public int beatLevelScore = 10;

    public GameObject playAgainButtons;
    public string playAgainLevelToLoad;

    public Text mainDisplay;

    // setup the game
    void Start()
    {
		mainDisplay.text = "0";

        // get a reference to the GameManager component for use by other scripts
        if (gm == null)
            gm = this.gameObject.GetComponent<GameManager>();

        // inactivate the playAgainButtons gameObject, if it is set
        if (playAgainButtons)
            playAgainButtons.SetActive(false);

    }

    // this is the main game event loop
    void Update()
    {
        if (!gameIsOver)
        {
            if (canBeatLevel && (score >= beatLevelScore))
            {  // check to see if beat game
                BeatLevel();
            } else {
				mainDisplay.text = score.ToString ();	
			}
        }
		else
        {
            EndGame();
            if (canBeatLevel && (score >= beatLevelScore)) { mainDisplay.text = "YOU WON!"; }
        }
    }

    void EndGame()
    {
        // game is over
        gameIsOver = true;

        // repurpose the timer to display a message to the player
        mainDisplay.text = "GAME OVER";

        // activate the playAgainButtons gameObject, if it is set 
        if (playAgainButtons)
            playAgainButtons.SetActive(true);
        Time.timeScale = 0;
    }

    void BeatLevel()
    {
        // game is over
        gameIsOver = true;

        // repurpose the timer to display a message to the player
        mainDisplay.text = "LEVEL COMPLETE";

        // activate the nextLevelButtons gameObject, if it is set 
        if (playAgainButtons)
            playAgainButtons.SetActive(true);
    }

    // public function that can be called to update the score or time
    public void enemyDead(int scoreAmount)
    {
        // increase the score by the scoreAmount and update the text UI
        score += scoreAmount;
    }

    // public function that can be called to restart the game
    public void RestartGame()
    {
        // we are just loading a scene (or reloading this scene)
        // which is an easy way to restart the level
        Application.LoadLevel(playAgainLevelToLoad);
    }
}
