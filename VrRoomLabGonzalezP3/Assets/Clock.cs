using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    public Text clockText;

    private void Awake()
    {
        clockText = GetComponent<Text>();
    }
    void Update()
    {
        DateTime time = DateTime.Now;
        string hour = LeadingZero(time.Hour);
        string minute = LeadingZero(time.Minute);
        string second = LeadingZero(time.Second);


        clockText.text = hour + ":" + minute + ":" + second; //13:44:13
    }

    string LeadingZero (int n)
    {
        return n.ToString().PadLeft(2, '0');
    }
}

