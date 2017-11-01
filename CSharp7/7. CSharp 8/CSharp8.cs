using System.ComponentModel;
using System.Diagnostics;

namespace CSharp7._7._CSharp_8
{
    [Description("[8] C# 8")]
    class CSharp8
    {
        static void Main(string[] args)
        {
            const string introSlidesUrl = "https://slides.com/zajkowskimarcin/whats-new-in-csharp-7-and-8/live#/27";

            var psi = new ProcessStartInfo("chrome.exe")
            {
                Arguments = introSlidesUrl
            };
            Process.Start(psi);
        }
    }
}
