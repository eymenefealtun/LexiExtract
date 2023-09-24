using static LexiExtract.Languages;
using System.Net;
using System.Text;

namespace LexiExtract
{
    internal static class Helpers
    {
        private static string baseUrl = "https://raw.githubusercontent.com/eymenefealtun/all-words-in-all-languages/main/";

        internal static string GetMainUrl(languages language)
        {
            return baseUrl + $"{language}/{language}.txt";
        }

        internal static void HandleHttp(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader readStream = response.CharacterSet == null ? new StreamReader(stream) : new StreamReader(stream, Encoding.GetEncoding(response.CharacterSet)))
                LexiExtractor._languageArray = readStream.ReadToEnd().Split(',');
        }

        internal static void AnotherHandleHttp(string url)
        {
            using (StreamReader reader = new StreamReader(new HttpClient().Send(new HttpRequestMessage(HttpMethod.Get, url)).Content.ReadAsStream()))
                LexiExtractor._languageArray = reader.ReadToEnd().Split(',');
        }



    }
}
