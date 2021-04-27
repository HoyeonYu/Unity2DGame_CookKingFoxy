using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatchGameDirector : MonoBehaviour
{
    GameObject timeGauge, hpGauge;
    float time = 0;
    float totalTime = 30f;

    void Start()
    {
        this.timeGauge = GameObject.Find("TimeGauge");
        this.hpGauge = GameObject.Find("HPGauge");
    }

    void Update()
    {
        this.time += Time.deltaTime;
        DecreaseTime();
    }

    public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.3f;
    }

    public void DecreaseTime()
    {
        this.timeGauge.GetComponent<Image>().fillAmount = (this.totalTime - this.time) / this.totalTime;
    }
}
