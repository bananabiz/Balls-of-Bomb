using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    public Text scoreText;
    public int score;
 
    void Start()
    {
        scoreText = this.GetComponent<Text>();
    }
	void Update ()
    {
        if(score < 10)
        {
            scoreText.text = "You have saved " + score.ToString() + " countries!";
        }
        else if (score == 10)
        {
            scoreText.text = "YOU WIN!!!";
            Application.Quit();
        }
	}
}
