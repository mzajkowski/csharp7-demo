using System;
using System.ComponentModel;
using System.Net.Http;
using System.Threading.Tasks;

namespace CSharp7._1._Async_Main
{
    [Description("[1] Async Main")]
    class AsyncMain
    {
        static async void Main()
        {
            var seriousTalkBetweenTwoExperienceBeconEaters = await JoinMemoriesFromLongLastingWhiskyNightsWithDangAsync();

            Console.WriteLine(seriousTalkBetweenTwoExperienceBeconEaters);
        }

        private static async Task<string> JoinMemoriesFromLongLastingWhiskyNightsWithDangAsync()
        {
            const string apiUrl = "https://baconipsum.com/api/";

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);

                var mySentenceApiCall = await client.GetAsync("?type=meat-and-filler&sentences=1&format=text");
                mySentenceApiCall.EnsureSuccessStatusCode();

                var dangsResponse = await client.GetAsync("?type=meat-and-filler&sentences=5&format=text");
                dangsResponse.EnsureSuccessStatusCode();

                var mySentence = await mySentenceApiCall.Content.ReadAsStringAsync();
                var dangsSentence = await dangsResponse.Content.ReadAsStringAsync();
                
                return $"\n\n[Marcin]: {mySentence}\n\n[Anthony]: {dangsSentence}\n\n";
            }
        }
    }
}
