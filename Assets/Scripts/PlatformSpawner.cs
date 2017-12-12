using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour {
    public GameManager manager;
    public GameObject groundPrefab;

    public void Spawn(Vector2 pos)
    {
        float height = Random.Range(manager.platLastHeight - 1, manager.platLastHeight + 1);
        GameObject lastPlat = (GameObject)Instantiate(groundPrefab);
        lastPlat.transform.position = new Vector2(pos.x + manager.platDis, height);
        manager.platLastHeight = height;
        //manager.platDis += manager.platDisIncrease;
    }
}
