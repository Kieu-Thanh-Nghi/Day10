using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeSpanExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TimeSpan duration = new TimeSpan(1, 30, 0);
        Debug.Log("TimeSpan Duration: " + duration);
        var now = DateTime.Now;
        var nextYear = new DateTime(2025,12,31);
        var timeLeft = nextYear - now;
        Debug.Log("Day left: " + timeLeft.Days);
    }
}
