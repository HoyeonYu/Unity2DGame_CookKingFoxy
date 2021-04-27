using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogController : MonoBehaviour
{
    float frogTime = 0;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(0, -0.001f, 0);
        this.frogTime += Time.deltaTime;

        if (transform.position.y < -5.0f || this.frogTime >= 5)
        {
            Destroy(gameObject);
        }
    }
}
