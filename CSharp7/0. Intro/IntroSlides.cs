using System.ComponentModel;
using System.Diagnostics;

namespace CSharp7._0._Intro
{
    [Description("[0] Intro")]
    class IntroSlides
    {
        static void Main(string[] args)
        {
            const string introSlidesUrl = "https://slides.com/zajkowskimarcin/co-nowego-w-csharp-7-i-8/live#/";

            var psi = new ProcessStartInfo("chrome.exe")
            {
                Arguments = introSlidesUrl
            };
            Process.Start(psi);
        }
    }
}
