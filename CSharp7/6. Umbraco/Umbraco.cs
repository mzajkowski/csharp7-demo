﻿using System.ComponentModel;
using System.Diagnostics;

namespace CSharp7._6._Umbraco
{
    [Description("[7] Latest C# with Umbraco")]
    class Umbraco
    {
        static void Main(string[] args)
        {
            const string introSlidesUrl = "https://slides.com/zajkowskimarcin/whats-new-in-csharp-7-and-8/live#/17";

            var psi = new ProcessStartInfo("chrome.exe")
            {
                Arguments = introSlidesUrl
            };
            Process.Start(psi);
        }
    }
}
