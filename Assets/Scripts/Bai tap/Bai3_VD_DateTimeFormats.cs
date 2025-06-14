using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class Bai3_VD_DateTimeFormats : MonoBehaviour
{
    private void Start()
    {
        dt();
    }
    void dt()
    {
        Debug.Log("=== DateTime Format Demo ===");

        DateTime now = DateTime.Now;

        // 1. Default format (ToString mac dinh)
        Debug.Log("Default: " + now.ToString());

        // 2. ISO 8601 (Chuan quoc te)
        Debug.Log("ISO 8601: " + now.ToString("yyyy-MM-ddTHH:mm:ss"));

        // 3. Dinh dang ngay thang nam
        Debug.Log("dd/MM/yyyy: " + now.ToString("dd/MM/yyyy"));
        Debug.Log("MM/dd/yyyy: " + now.ToString("MM/dd/yyyy"));
        Debug.Log("yyyy-MM-dd: " + now.ToString("yyyy-MM-dd"));

        // 4. Dinh dang gio phut giay
        Debug.Log("HH:mm:ss (24h): " + now.ToString("HH:mm:ss"));
        Debug.Log("hh:mm tt (12h): " + now.ToString("hh:mm tt"));    //tt la AM hoac PM

        // 5. Dinh dang day du ngay gio
        Debug.Log("Full: " + now.ToString("dddd, dd MMMM yyyy HH:mm:ss")); //dddd va MMMM la ngay trong tuan va thang duoc viet theo chu day du
                                                                           //MMM la thang viet tat vd: Jan, Feb, Jun
                                                                           //yy la nam viet tat 2 so cuoi
                                                                           // Vi du: "Saturday, 14 June 2025 14:25:03"

        // 6. Dinh dang rut gon
        Debug.Log("Short date: " + now.ToString("d"));  // 14/06/2025 ,d la chi ngay thang nam
        Debug.Log("Short time: " + now.ToString("t"));  // 14:25      ,t la chi gio va phut

        // 7. Culture-specific (dinh dang theo van hoa)
        CultureInfo viVN = new CultureInfo("vi-VN");
        CultureInfo enUS = new CultureInfo("en-US");

        Debug.Log("Viet Nam: " + now.ToString("f", viVN));  // Thu bay, ngay 14 thang 6 nam 2025 14:25
        Debug.Log("English (US): " + now.ToString("f", enUS));  // Saturday, June 14, 2025 2:25 PM

        // 8. Tuy chinh nang cao voi viec chen them chuoi vao format
        string custom = now.ToString("'Today is' dddd, MMM dd yyyy 'at' hh:mm tt");
        Debug.Log("Custom: " + custom);  // Today is Saturday, Jun 14 2025 at 02:25 PM
    }

}
