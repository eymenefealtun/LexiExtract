namespace LexiExtract
{
    public static class LexiExtractor
    {
        private static Random _random = new Random();

        /// <summary>
        /// Returns random words from the source array.
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

        /// <summary>
        /// Return one random word from the source array.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string GetRandomWord(this string[] source)
        {
            return source[_random.Next(source.Length)];
        }

    }
}
