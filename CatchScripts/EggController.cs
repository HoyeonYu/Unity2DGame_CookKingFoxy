using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggController : MonoBehaviour
{
    float eggTime = 0;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(0, -0.001f, 0);
        this.eggTime += Time.deltaTime;

        if (transform.position.y < -5.0f || this.eggTime >= 5.0)
        {
            Destroy(gameObject);
        }
    }
}