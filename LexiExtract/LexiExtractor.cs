using LexiExtract.Exceptions;

namespace LexiExtract
{
    public static class LexiExtractor
    {
        private static Random _random = new Random();


        /// <summary>
        /// Extracts all the available words from the server.
        /// </summary>
        /// <returns>
        /// a string array.
        /// </returns>
        /// <param name="language"></param>
        /// <exception cref="LanguageNotFoundException"></exception>
        public static string[] GetLanguageArray(Languages language)
        {
            try
            {
                return Helpers.ExtractArray(Helpers.GetMainUrl(language));
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
        /// a string array.
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
