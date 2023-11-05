using System.Net;
using System.Text;

namespace LexiExtract
{
    internal static class Helpers
    {
        private static string baseUrl = "https://raw.githubusercontent.com/eymenefealtun/all-words-in-all-languages/main/";
        private static HttpClient _httpClient = new HttpClient();

        internal static string GetMainUrl(string language)
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

        internal async static Task<string[]> ExtractArrayAsync(string url)
        {
            using (HttpResponseMessage response = await _httpClient.GetAsync(url))
            {
                string content = await response.Content.ReadAsStringAsync();
                return content.Split(',');
            }
        }


    }
}
