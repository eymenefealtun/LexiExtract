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

        internal static string[] ExtractArray(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader readStream = response.CharacterSet == null ? new StreamReader(stream) : new StreamReader(stream, Encoding.GetEncoding(response.CharacterSet)))
                return readStream.ReadToEnd().Split(',');
        }
    }
}
