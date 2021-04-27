using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashControllerChild : MonoBehaviour
{
    bool isAngleIncrease = true;

    void Start()
    {

    }

    void Update()
    {
        int dir = (this.isAngleIncrease ? 1 : -1);

        if (gameObject.transform.rotation.z > 1/3f && this.isAngleIncrease)
        {
            this.isAngleIncrease = false;
        }

        if (gameObject.transform.rotation.z < 1/-3f && !this.isAngleIncrease)
        {
            this.isAngleIncrease = true;
        }

        transform.Rotate(new Vector3(0, 0, 120f * dir) * Time.deltaTime);
    }
}
