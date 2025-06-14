using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class Bai5_VD_string2Number : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Str2Numb();
    }

    void Str2Numb()
    {
        Debug.Log("=== String Å® Number Examples ===");

        // 1. int.Parse
        string s1 = "123";
        int n1 = int.Parse(s1);
        Debug.Log("int.Parse: " + n1); // 123

        // 2. int.TryParse
        string s2 = "abc";
        if (int.TryParse(s2, out int n2))
        {
            Debug.Log("TryParse OK: " + n2);
        }
        else
        {
            Debug.LogWarning("TryParse FAIL: '" + s2 + "'");
        }

        // 3. float.Parse
        string s3 = "3.14";
        float f3 = float.Parse(s3, CultureInfo.InvariantCulture); // can CultureInfo neu may dung dau ,
        Debug.Log("float.Parse: " + f3);

        // 4. double.Parse
        string s4 = "12345.678";
        double d4 = double.Parse(s4, CultureInfo.InvariantCulture);
        Debug.Log("double.Parse: " + d4);

        // 5. decimal.Parse
        string s5 = "9999.99";
        decimal m5 = decimal.Parse(s5, CultureInfo.InvariantCulture); //dung khi can do chinh xac cao nhu tien te
        Debug.Log("decimal.Parse: " + m5);

        // 6. Convert.ToInt32
        string s6 = "456";
        int n6 = Convert.ToInt32(s6); // string thanh Int
        Debug.Log("Convert.ToInt32: " + n6);

        // 7. Convert voi gia tri rong hoac null
        string s7 = null;
        try
        {
            int n7 = Convert.ToInt32(s7); // return 0 neu null
            Debug.Log("Convert null Å® int: " + n7);
        }
        catch (Exception ex)
        {
            Debug.LogError("Convert null FAIL: " + ex.Message);
        }

        // 8. Convert.ToSingle
        string s8 = "5.75";
        float f8 = Convert.ToSingle(s8, CultureInfo.InvariantCulture); //string thanh float
        Debug.Log("Convert.ToSingle: " + f8);
    }

}
