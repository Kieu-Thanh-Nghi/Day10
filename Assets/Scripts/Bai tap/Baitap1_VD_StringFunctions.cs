using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class Baitap1_VD_StringFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StrFuncExam();
    }

    void StrFuncExam()
    {
        Debug.Log("=== String Demo ===");

        // 1. Length - Tra ve so ki tu trong chuoi
        string str1 = "Hello";
        Debug.Log("Length: " + str1.Length);  // 5

        // 2. ToUpper / ToLower - Chuyen chu tuong sang in hoa va nguoc lai
        Debug.Log("ToUpper: " + str1.ToUpper());  // "HELLO"
        Debug.Log("ToLower: " + str1.ToLower());  // "hello"

        // 3. Contains - Kiem tra chuoi co chua tu con khong?
        string str2 = "Unity Game";
        Debug.Log("Contains 'Unity': " + str2.Contains("Unity"));  // true

        // 4. StartsWith / EndsWith - Kiem tra chuoi co bat dau hoac ket thuc bang 1 tu nao do hay khong?
        string str3 = "GameDev";
        Debug.Log("StartsWith 'Game': " + str3.StartsWith("Game"));  // true
        Debug.Log("EndsWith 'Dev': " + str3.EndsWith("Dev"));        // true

        // 5. IndexOf / LastIndexOf - Tim vi tri xuat hien dau va cuoi cua 1 ki tu hoac chuoi con
        string str4 = "banana";
        Debug.Log("IndexOf 'a': " + str4.IndexOf("a"));          // 1
        Debug.Log("LastIndexOf 'a': " + str4.LastIndexOf("a"));  // 5

        // 6. Substring - Cat chuoi con tu 1 vi tri ta nhap vao voi 1 do dai nhat dinh
        string str5 = "Unity3D";
        Debug.Log("Substring(0,5): " + str5.Substring(0, 5));  // "Unity"

        // 7. Replace - Thay the chuoi con nay bang chuoi con khac
        string str6 = "C# is cool";
        Debug.Log("Replace: " + str6.Replace("cool", "awesome"));  // "C# is awesome"

        // 8. Split - Tach chuoi thanh mang dua tren ki tu phan cach nao do
        string str7 = "apple,banana,cherry";
        string[] parts = str7.Split(',');
        Debug.Log("Split: " + string.Join(" | ", parts));  // "apple | banana | cherry"

        // 9. Trim - Loai bo khoang trang o dau va cuoi chuoi
        string str8 = "  hello world  ";
        Debug.Log("Trim: [" + str8.Trim() + "]");  // "hello world"

        // 10. Equals - So sanh chuoi (StringComparison.OrdinalIgnoreCase la khong phan biet hoa thuong, StringComparison.Ordinal thi co)
        string str9a = "test";
        string str9b = "Test";
        Debug.Log("Equals (ignore case): " + str9a.Equals(str9b, StringComparison.OrdinalIgnoreCase));  // true

        // 11. IsNullOrEmpty / IsNullOrWhiteSpace - Kiem tra chuoi co rong/Null/trang khong?
        string str10 = "";
        Debug.Log("IsNullOrEmpty: " + string.IsNullOrEmpty(str10));        // true
        Debug.Log("IsNullOrWhiteSpace: " + string.IsNullOrWhiteSpace(" ")); // true

        // 12. Format - Chen bien vao chuoi theo dinh dang
        string name = "Alice";
        int age = 25;
        Debug.Log(string.Format("{0} is {1} years old", name, age));  // "Alice is 25 years old"

        // 13. Join - Noi cac phan tu thanh chuoi voi dau phan cach
        string[] fruits = { "Apple", "Banana", "Cherry" };
        Debug.Log("Join: " + string.Join(" - ", fruits));  // "Apple - Banana - Cherry"

        // 14. PadLeft / PadRight - Them ky tu vao trai/phai chuoi cho du do dai
        string number = "42";
        Debug.Log("PadLeft: " + number.PadLeft(5, '0'));   // "00042"
        Debug.Log("PadRight: " + number.PadRight(5, '_')); // "42___"

        // 15. Remove - Xoa mot phan chuoi bat dau tu 1 vi tri ta nhap vao
        string str11 = "abcdef";
        Debug.Log("Remove(2,2): " + str11.Remove(2, 2));  // "abef"
    }

}
