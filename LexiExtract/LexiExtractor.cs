using LexiExtract.Exceptions;

namespace LexiExtract
{
    public static class LexiExtractor
    {

        internal static string[]? _languageArray;

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
            try
            {
                Helpers.AnotherHandleHttp(Helpers.GetMainUrl(language));
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
