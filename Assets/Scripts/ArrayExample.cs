using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    [SerializeField] private int[] numbers = new int[5];
    // Start is called before the first frame update
    void Start()
    {
        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;
        numbers[3] = 4;
        numbers[4] = 5;

        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log("Element " + i + ": " + numbers[i]);
        }
    }
}
