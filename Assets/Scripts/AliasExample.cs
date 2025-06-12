using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ProjectAlias = System.Collections.Generic.Dictionary<string, int>;

public class AliasExample : MonoBehaviour
{
    private ProjectAlias myDict;
    // Start is called before the first frame update
    void Start()
    {
        myDict = new ProjectAlias();
        myDict["Key1"] = 1;
        myDict["Key2"] = 2;
        Debug.Log("Value for Key1: " + myDict["Key1"]);
    }
}
