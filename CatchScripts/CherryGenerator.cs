using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryGenerator : MonoBehaviour
{
    public GameObject cherryPrefab;
    float span = 2.3f;
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
            GameObject go = Instantiate(cherryPrefab) as GameObject;

            float px = Random.Range(-16, 11);
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
