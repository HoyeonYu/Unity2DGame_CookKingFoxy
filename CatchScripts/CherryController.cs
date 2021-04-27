using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryController : MonoBehaviour
{
    float cherryTime = 0;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(0, -0.001f, 0);
        this.cherryTime += Time.deltaTime;

        if (transform.position.y < -5.0f || this.cherryTime >= 5.0)
        {
            Destroy(gameObject);
        }
    }
}
