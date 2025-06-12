using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DateTimeAndTimeSpanMethods : MonoBehaviour
{
    [SerializeField] private DateTime now;
    [SerializeField] private DateTime futureDate;
    [SerializeField] private TimeSpan duration;
    private double totalMinutes;
    // Start is called before the first frame update
    void Start()
    {

        now = DateTime.Now;
        futureDate = now.AddDays(10);
        Debug.Log("Future Date: " + futureDate);

        duration = new TimeSpan(2, 15, 26);
        totalMinutes = duration.TotalMinutes;
        Debug.Log("Total Minutes: " + totalMinutes);
    }
}
