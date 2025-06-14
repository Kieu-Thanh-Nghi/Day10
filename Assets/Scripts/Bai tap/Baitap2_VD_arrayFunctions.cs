using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class Baitap2_VD_arrayFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        arrFuncsExamp();
    }

    void arrFuncsExamp()
    {
        Debug.Log("=== Array Demo ===");

        // 1. Sort
        int[] numbers1 = { 5, 2, 9, 1 };
        Array.Sort(numbers1);
        Debug.Log("Sort: " + string.Join(", ", numbers1));

        // 2. Reverse
        int[] numbers2 = { 1, 2, 3 };
        Array.Reverse(numbers2);
        Debug.Log("Reverse: " + string.Join(", ", numbers2));

        // 3. IndexOf
        string[] names = { "Alice", "Bob", "Charlie" };
        int index1 = Array.IndexOf(names, "Bob");
        Debug.Log("IndexOf 'Bob': " + index1);

        // 4. LastIndexOf
        int[] numbers3 = { 1, 2, 3, 2 };
        int index2 = Array.LastIndexOf(numbers3, 2);
        Debug.Log("LastIndexOf 2: " + index2);

        // 5. Find
        int[] numbers4 = { 1, 2, 3, 4, 5 };
        int found = Array.Find(numbers4, x => x > 3);//tra ve gia tri dau tien thoa man dieu kien
        Debug.Log("Find > 3: " + found);
        /*x => x > 3 tuong duong voi
        bool Check(int x) {
            return x > 3;
        }
        Co the viet la:
        int result = Array.Find(numbers, Check);*/

        // 6. FindAll
        int[] evens = Array.FindAll(numbers4, x => x % 2 == 0);//tra ve tat ca gia tri thoa man dieu kien x la so chan
        Debug.Log("FindAll Even: " + string.Join(", ", evens));

        // 7. Exists
        string[] fruits = { "Apple", "Banana", "Cherry" };
        bool hasApple = Array.Exists(fruits, f => f.StartsWith("A"));
        Debug.Log("Exists starts with 'A': " + hasApple);

        // 8. Clear
        int[] numbers5 = { 1, 2, 3, 4 };
        Array.Clear(numbers5, 1, 2);
        Debug.Log("Clear index 1-2: " + string.Join(", ", numbers5));

        // 9. Copy
        int[] source = { 10, 20, 30 };
        int[] dest = new int[3];
        Array.Copy(source, dest, 3);
        Debug.Log("Copy: " + string.Join(", ", dest));

        // 10. BinarySearch
        int[] numbers7 = { 1, 3, 5, 7 };
        int index3 = Array.BinarySearch(numbers7, 5);//Tim gia tri theo phuong phap cay nhi phan,
                                                     //array phai xap xep tang dan thi moi dung duoc
        Debug.Log("BinarySearch 5: " + index3);

        // 11. Clone
        int[] numbers8 = { 1, 2, 3 };
        int[] copy = (int[])numbers8.Clone();
        Debug.Log("Clone: " + string.Join(", ", copy));
    }
}
