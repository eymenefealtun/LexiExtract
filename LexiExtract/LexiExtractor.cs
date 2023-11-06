namespace LexiExtract
{
    public static class LexiExtractor
    {
        private static Random _random = new Random();

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
