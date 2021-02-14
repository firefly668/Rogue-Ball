using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeText : MonoBehaviour
{
    int minute;
    int second;
    bool flag=true;

    // 已经花费的时间
    float timeSpend = 0.0f;

    // 显示时间区域的文本

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {
        if (flag)
        {
            timeSpend += Time.deltaTime;
            //GlobalSetting.timeSpent = timeSpend;

            minute = (int)timeSpend / 60;
            second = (int)timeSpend - minute * 60;
            this.GetComponent<Text>().text = minute.ToString() + ":" + second.ToString();
        }

}

}
