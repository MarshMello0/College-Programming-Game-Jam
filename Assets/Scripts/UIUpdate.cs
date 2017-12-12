using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIUpdate : MonoBehaviour
{
    public Text score,highscore;
    public GameManager manager;
    void Update()
    {
        score.text = "Score: " + manager.score;
        highscore.text = "Highscore: " + manager.highscore.HighScore + "\nLastscore: " + manager.highscore.LastScore;
    }
}
