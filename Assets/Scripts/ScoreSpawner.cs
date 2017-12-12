using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSpawner : MonoBehaviour
{
    public Transform s1, s2, s3;
    public GameObject score;
    void Start()
    {
        GameObject lastscore = (GameObject)Instantiate(score);
        lastscore.transform.position = new Vector2(s1.position.x,s1.position.y);

        GameObject lastscore2 = (GameObject)Instantiate(score);
        lastscore2.transform.position = new Vector2(s2.position.x, s2.position.y);

        GameObject lastscore3 = (GameObject)Instantiate(score);
        lastscore3.transform.position = new Vector2(s3.position.x, s3.position.y);
    }
}
