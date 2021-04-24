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
        infoText[0] = "나는야 요리왕 폭시!\n\n";
        infoText[1] = "어떤 요리를 할지 <b>룰렛</b>으로 정해보자.\n";
        infoText[2] = "룰렛은 <b>마우스</b>를 누르면 돌아가고, 마우스를 떼면 멈춰.\n\n";
        infoText[3] = "먼저 필요한 재료를 <b>제한시간</b> 내에 모아야 돼.\n";
        infoText[4] = "재료는 <b>하늘</b>에서 떨어지고, 몸에 닿으면 <b>인벤토리</b>에 저장돼.\n";
        infoText[5] = "<b>쓰레기</b>에 닿으면 재료가 모두 상하니 조심하자.\n";
        infoText[6] = "이동은 <b>방향키</b>로, 점프는 <b>스페이스바</b>로 할 수 있어.\n";
        infoText[7] = "<b>화면</b>이 자동으로 움직이고, 아래로 떨어질 수 있으니 주의하고!\n\n";
        infoText[8] = "다 모은 후 요리 <b>시간</b>에 맞춰 재료를 <b>순서대로</b> 넣으면 돼.\n";
        infoText[9] = "넣을 땐 인벤토리에서 재료를 <b>마우스</b>로 끌어서 넣자.\n\n";
        infoText[10] = "그러면 이제 요리를 시작해볼까? Let's Go!!";
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
