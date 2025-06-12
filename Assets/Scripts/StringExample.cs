using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringExample : MonoBehaviour
{
    [SerializeField] private string message;
    [SerializeField] private string greeting;
    [SerializeField] private string name;
    [SerializeField] private string welcome;
    // Start is called before the first frame update
    void Start()
    {
        message = "Hello, Unity!";
        greeting = "Hello, " + "World!";
        name = "Unity";
        welcome = $"Welcome to {name} programming!";

        Debug.Log(message);
        Debug.Log(greeting);
        Debug.Log(welcome);
    }
}
