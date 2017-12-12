using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    public Transform target, gameCamera;
    void FixedUpdate()
    {
        gameCamera.position = new Vector3(target.position.x, gameCamera.position.y,gameCamera.position.z);
    }
}
