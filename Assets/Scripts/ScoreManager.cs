using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public GameManager manager;
    void Start()
    {
        manager = GameObject.Find("_GameManager").GetComponent<GameManager>();
    }
    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.tag == "Player")
        {
            manager.score++;
            Destroy(gameObject);
        }

    }
}
