using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashController : MonoBehaviour
{
    float trashTime = 0;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(0, -0.001f, 0);
        this.trashTime += Time.deltaTime;

        if (transform.position.y < -5.0f || this.trashTime >= 7)
        {
            Destroy(gameObject);
        }
    }
}
