using System.Net;
using System.Text;

namespace LexiExtract
{
    public static class LexiExtractor
    {


        private static string[] _languageArray;
        private static string _url = "";
        private static Random _random = new Random();

        /// <summary>
        /// Returns all the available words from the target server.
        /// </summary>
        /// <param name="language"></param>
        /// <returns></returns>
        public static string[] GetLanguageArray(Language language)
        {
            try
            {
                _url = language.MainUrl;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode != HttpStatusCode.OK) return null;


                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = response.CharacterSet == null ? new StreamReader(receiveStream) : new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));


                _languageArray = readStream.ReadToEnd().Split(',');
                response.Close();
                readStream.Close();

                return _languageArray;

            }
            catch (Exception)
            {
                return null;
            }
        }


        public static string[] GetRandomWords(this string[] source, int numberOfWords)
        {
            string[] resultArray = new string[numberOfWords];

            for (int i = 0; i < numberOfWords; i++)
                resultArray[i] = source[_random.Next(0, source.Length)];

            return resultArray;
        }



    }
}
