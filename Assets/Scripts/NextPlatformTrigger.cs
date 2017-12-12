using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPlatformTrigger : MonoBehaviour {
    public PlatformSpawner spawner;
    bool hasSpawned;
    void Start()
    {
        spawner = GameObject.Find("_GameManager").GetComponent<PlatformSpawner>();
    }
    void OnTriggerEnter2D(Collider2D c)
    {
        if(!hasSpawned && c.tag == "Player")
        {
            spawner.Spawn(transform.position);
            hasSpawned = true;
        }
        
    }
}
