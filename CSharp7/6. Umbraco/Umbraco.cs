using System.ComponentModel;
using System.Diagnostics;

namespace CSharp7._6._Umbraco
{
    [Description("[7] Latest C# with Umbraco")]
    class Umbraco
    {
        static void Main(string[] args)
        {
            const string introSlidesUrl = "https://slides.com/zajkowskimarcin/co-nowego-w-csharp-7-i-8/live#/17";

            var psi = new ProcessStartInfo("chrome.exe")
            {
                Arguments = introSlidesUrl
            };
            Process.Start(psi);
        }
    }
}
