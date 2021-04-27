using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject roulette, timerText;
    GameObject[] highLightMenu = new GameObject[3];

    float rotSpeed = 0;
    float rotAngle = 0;
    bool isRotated = false;
    float time = 0;

    void Start()
    {
        this.roulette = GameObject.Find("Roulette");
        this.highLightMenu[0] = GameObject.Find("HighlightMenu1");
        this.highLightMenu[1] = GameObject.Find("HighlightMenu2");
        this.highLightMenu[2] = GameObject.Find("HighlightMenu3");
        this.timerText = GameObject.Find("TimerText");

        for (int i = 0; i < highLightMenu.Length; i++)
        {
            this.highLightMenu[i].SetActive(false);
        }
    }

    void Update()
    {
        if (Input.GetMouseButton(0) && !this.isRotated)
        {
            this.rotSpeed = 20;
            this.rotAngle += this.rotSpeed;
            this.roulette.transform.Rotate(0, 0, this.rotSpeed);
        }

        else
        {
            this.rotSpeed *= 0.99f;
            this.rotAngle += this.rotSpeed;
            this.roulette.transform.Rotate(0, 0, this.rotSpeed);

            if (this.rotSpeed < 0.001 && this.rotSpeed != 0)
            {
                this.rotSpeed = 0;
                this.isRotated = true;
                this.rotAngle %= 360;

                for (int i = 0; i < 7; i++)
                {
                    if ((i * 60) - 30 <= this.rotAngle && this.rotAngle <= (i * 60) + 30)
                    {
                        this.highLightMenu[(i % 3)].SetActive(true);
                        break;
                    }
                }
            }
        }

        if (isRotated)
        {
            this.time += Time.deltaTime;
            float remainTime = 4 - time;
            this.timerText.GetComponent<Text>().text = ((int)remainTime).ToString() + "초 후 게임이 시작됩니다.";

            if (remainTime <= 0)
            {
                this.timerText.GetComponent<Text>().text = ("0초 후 게임이 시작됩니다.");
            }
        }
    }
}
