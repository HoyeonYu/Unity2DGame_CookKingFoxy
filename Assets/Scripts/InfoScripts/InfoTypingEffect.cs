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
        infoText[0] = "나는야 요리왕 폭시!\n";
        infoText[1] = "어떤 요리를 할지 <b>룰렛</b>으로 정해보자.\n\n";
        infoText[2] = "요리를 정하면 필요한 재료를 <b>제한시간 1분</b> 내에 모아야 돼.\n";
        infoText[3] = "재료는 하늘에서 떨어져 맵 곳곳에 <b>10초</b>동안 남아있어\n";
        infoText[4] = "주변에 가서 <b>s키</b>로 후라이팬을 휘둘러 <b>인벤토리</b>에 저장하자.\n";
        infoText[5] = "<b>쓰레기</b>에 몸이 닿으면 재료가 모두 상해서 없어지니 조심하자.\n\n";
        infoText[6] = "이동은 <b>방향키</b>로, 점프는 <b>스페이스바</b>로 할 수 있어.\n";
        infoText[7] = "가끔 천적인 <b>독수리</b>가 날아다니니 피해야 돼.\n\n";
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
