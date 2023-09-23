using LexiExtract.Exceptions;
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
        /// Extracts all the available words from the server.
        /// </summary>
        /// <returns>
        /// Returns string array.
        /// </returns>
        /// <param name="language"></param>
        /// <returns></returns>
        public static string[] GetLanguageArray(Languages.languages language)
        {
            if (Languages.mainWords.Count == 0) Helpers.SetMainSourceDictionary();

            try
            {
                _url = Helpers.GetUrl(language, Languages.mainWords);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = response.CharacterSet == null ? new StreamReader(receiveStream) : new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));


                _languageArray = readStream.ReadToEnd().Split(',');

                response.Close();
                readStream.Close();

                return _languageArray;
            }
            catch (Exception)
            {
                throw new LanguageNotFoundException($"Your internet connection might be broken, or the server may be down.");
            }

        }


        /// <summary>
        /// Returns random words array.
        /// </summary>
        /// <returns>
        /// Returns string array.
        /// </returns>
        /// <param name="source"> asdasdasdasdasd</param>
        /// <param name="numberOfWords"></param>
        /// <returns></returns>
        public static string[] GetRandomWords(this string[] source, int numberOfWords)
        {
            string[] resultArray = new string[numberOfWords];

            for (int i = 0; i < numberOfWords; i++)
                resultArray[i] = source[_random.Next(source.Length)];

            return resultArray;
        }

    }
}
