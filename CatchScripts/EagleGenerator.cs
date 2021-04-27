using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleGenerator : MonoBehaviour
{
    public GameObject eaglePrefab;
    float span = 12.0f;
    float delta = 0;
    void Start()
    {

    }

    void Update()
    {
        this.delta += Time.deltaTime;

        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(eaglePrefab) as GameObject;

            float px = Random.Range(10, 13);
            float py = Random.Range(2, 4);
            go.transform.position = new Vector3(px, py, 0);
        }
    }
}
