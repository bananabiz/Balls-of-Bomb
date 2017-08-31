using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager2 : MonoBehaviour
{
    public Text score2Text;
    public int score2;

    void Start()
    {
        score2Text = this.GetComponent<Text>();
    }
    void Update()
    {
        if (score2 < 10)
        {
            score2Text.text = "Target destroyed: " + score2.ToString();
        }
        else if (score2 == 10)
        {
            score2Text.text = "YOU LOSE!!!";
            Application.Quit();
        }
    }
}