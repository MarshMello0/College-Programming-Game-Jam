using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public bool inGame;
    public float platDis,platDisIncrease,platLastHeight;
    public int score;

    public Highscore highscore;

    public void Dead()
    {
        highscore.LastScore = score;
        if (score > highscore.HighScore)
        {
            highscore.HighScore = score;
        }
        SceneManager.LoadScene(0);
    }
}
