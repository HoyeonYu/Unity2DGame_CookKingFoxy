using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("Player");
    }

    void Update()
    {
        Vector3 playerPos = this.player.transform.position;

        if (-8.5f < playerPos.x && playerPos.x < 1.6f)
        {
            transform.position = new Vector3(playerPos.x, transform.position.y, transform.position.z);
        }
    }
}
