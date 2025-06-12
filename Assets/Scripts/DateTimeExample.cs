using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DateTimeExample : MonoBehaviour
{
    [SerializeField] private DateTime now;
    [SerializeField] private DateTime specificDate;
    // Start is called before the first frame update
    void Start()
    {
        now = DateTime.Now;
        specificDate = new DateTime(2024, 5, 25);
        string dateFormat = "dd/MM/yyyy HH:mm:ss";

        Debug.Log("Current Date and Time: " + now);
        Debug.Log("Specific Date: " + specificDate.ToString(dateFormat)); 
    }
}
