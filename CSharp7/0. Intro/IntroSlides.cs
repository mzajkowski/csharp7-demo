using System.Diagnostics;

namespace CSharp7._0._Intro
{
    class IntroSlides
    {
        static void Main(string[] args)
        {
            const string introSlidesUrl = "https://slides.com/zajkowskimarcin/";

            var psi = new ProcessStartInfo("chrome.exe")
            {
                Arguments = introSlidesUrl
            };
            Process.Start(psi);
        }
    }
}
