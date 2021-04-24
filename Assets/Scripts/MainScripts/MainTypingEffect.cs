using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainTypingEffect : MonoBehaviour
{
    public Text tx;
    private string subTitle = "요리하는 여우 폭시를 도와\n레시피를 완성시키자!";

    void Start()
    {
        StartCoroutine(_typing());
    }

    void Update()
    {
        
    }

    IEnumerator _typing()
    {
        yield return new WaitForSeconds(0.1f);

        for (int i = 0; i <= subTitle.Length; i++)
        {
            tx.text = subTitle.Substring(0, i);

            yield return new WaitForSeconds(0.15f);
        }
    }
}
