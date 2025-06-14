using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class Bai4_VD_datetimeParse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        parseExamp();
    }
    void parseExamp()
    {
        Debug.Log("=== DateTime.Parse / ParseExact Examples ===");

        DateTime d1 = DateTime.Parse("2025-06-14");
        Debug.Log("Parsed 1: " + d1);  // 14/06/2025 00:00:00

        DateTime d2 = DateTime.Parse("2025-06-14 15:30:00");
        Debug.Log("Parsed 2: " + d2);  // 14/06/2025 15:30:00

        //Parse theo dinh dang my (thang/ngay/nam)
        CultureInfo enUS = new CultureInfo("en-US");
        DateTime d3 = DateTime.Parse("12/25/2025", enUS);
        Debug.Log("Parsed 3 (US): " + d3);  // 25/12/2025

        //Parse theo dinh dang Viet Nam (ngay/thang/nam)
        CultureInfo viVN = new CultureInfo("vi-VN");
        DateTime d4 = DateTime.Parse("25/12/2025", viVN);
        Debug.Log("Parsed 4 (VN): " + d4);  // 25/12/2025

        //Parse dinh dang ISO 8601
        DateTime d5 = DateTime.Parse("2025-06-14T10:45:00");
        Debug.Log("Parsed 5 (ISO): " + d5);  // 14/06/2025 10:45:00

        //Parse voi gio UTC (co chu 'Z')
        DateTime d6 = DateTime.Parse("2025-06-14T10:45:00Z", null, DateTimeStyles.AdjustToUniversal);
        Debug.Log("Parsed 6 (UTC): " + d6.ToString("u"));  // In ra theo gio UTC

        // Dinh dang kieu Viet Nam dd/MM/yyyy
        string dateStr2 = "14/06/2025";
        DateTime dt2 = DateTime.ParseExact(dateStr2, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        Debug.Log("Parsed 2: " + dt2);

        //Them gio phut giay: "dd-MM-yyyy HH:mm:ss"
        string dateStr3 = "14-06-2025 16:30:45";
        DateTime dt3 = DateTime.ParseExact(dateStr3, "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        Debug.Log("Parsed 3: " + dt3);

        // 6. Dinh dang tuy chinh co chu
        string dateStr6 = "Ngay 14 thang 06 nam 2025";
        DateTime dt6 = DateTime.ParseExact(dateStr6, "'Ngay' dd 'thang' MM 'nam' yyyy", CultureInfo.InvariantCulture);
        Debug.Log("Parsed 6 (custom Vietnamese): " + dt6);

        //TryParseExact
        string input = "14/06/2025";
        if (DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result))
        {
            Debug.Log("Parse thanh cong: " + result);
        }
        else
        {
            Debug.LogWarning("Sai dinh dang!");
        }
    }

}
