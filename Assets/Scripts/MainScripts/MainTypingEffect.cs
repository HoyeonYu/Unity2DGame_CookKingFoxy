using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainTypingEffect : MonoBehaviour
{
    public Text tx;
    private string subTitle = "�丮�ϴ� ���� ���ø� ����\n�����Ǹ� �ϼ���Ű��!";

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
