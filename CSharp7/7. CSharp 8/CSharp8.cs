﻿using System.ComponentModel;
using System.Diagnostics;

namespace CSharp7._7._CSharp_8
{
    [Description("[8] C# 8")]
    class CSharp8
    {
        static void Main(string[] args)
        {
            const string introSlidesUrl = "https://slides.com/zajkowskimarcin/co-nowego-w-csharp-7-i-8/live#/27";

            var psi = new ProcessStartInfo("chrome.exe")
            {
                Arguments = introSlidesUrl
            };
            Process.Start(psi);
        }
    }
}
