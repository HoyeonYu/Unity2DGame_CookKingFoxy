using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoTypingEffect : MonoBehaviour
{
    public Text tx;
    private string[] infoText = new string[20];

    void Start()
    {
        StartCoroutine(_typing());
        infoText[0] = "���¾� �丮�� ����!\n\n";
        infoText[1] = "� �丮�� ���� <b>�귿</b>���� ���غ���.\n";
        infoText[2] = "�귿�� <b>���콺</b>�� ������ ���ư���, ���콺�� ���� ����.\n\n";
        infoText[3] = "���� �ʿ��� ��Ḧ <b>���ѽð�</b> ���� ��ƾ� ��.\n";
        infoText[4] = "���� <b>�ϴ�</b>���� ��������, ���� ������ <b>�κ��丮</b>�� �����.\n";
        infoText[5] = "<b>������</b>�� ������ ��ᰡ ��� ���ϴ� ��������.\n";
        infoText[6] = "�̵��� <b>����Ű</b>��, ������ <b>�����̽���</b>�� �� �� �־�.\n";
        infoText[7] = "<b>ȭ��</b>�� �ڵ����� �����̰�, �Ʒ��� ������ �� ������ �����ϰ�!\n\n";
        infoText[8] = "�� ���� �� �丮 <b>�ð�</b>�� ���� ��Ḧ <b>�������</b> ������ ��.\n";
        infoText[9] = "���� �� �κ��丮���� ��Ḧ <b>���콺</b>�� ��� ����.\n\n";
        infoText[10] = "�׷��� ���� �丮�� �����غ���? Let's Go!!";
    }

    void Update()
    {

    }

    IEnumerator _typing()
    {
        yield return new WaitForSeconds(0.1f);

        for (int i = 0; i < infoText.Length; i++)
        {
            tx.text += infoText[i];

            yield return new WaitForSeconds(0.1f);
        }
    }
}
