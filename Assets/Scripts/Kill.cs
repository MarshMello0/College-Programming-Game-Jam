using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill : MonoBehaviour
{
    public GameManager manager;

    void OnCollisionEnter2D(Collision2D coll)
    {
        manager.Dead();
        manager.inGame = false;
    }
}
