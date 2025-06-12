using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParseExample : MonoBehaviour
{
    private string strNum;
    private int num;
    // Start is called before the first frame update
    void Start()
    {
        strNum = "123";
        num = int.Parse(strNum);
        Debug.Log("Parsed Number: " + num);
    }
}
