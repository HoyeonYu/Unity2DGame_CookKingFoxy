using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleController : MonoBehaviour
{
    float eagleTime = 0;
    Vector3 eaglePos;

    void Start()
    {
        eaglePos = transform.position;
    }

    void Update()
    {
        transform.position = eaglePos + new Vector3(-this.eagleTime * 4f, Mathf.Sin(this.eagleTime * 4f) * 0.8f, 0);
        this.eagleTime += Time.deltaTime;

        if (transform.position.x < -20.0f || this.eagleTime >= 10.0)
        {
            Destroy(gameObject);
        }
    }
}
