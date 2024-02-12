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



        /// <summary>
        /// Return all the available language classes.
        /// </summary>
        /// <returns></returns>
        public static List<Language> GetLanguages()
        {
            return typeof(Language).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(Language))).Select(t => (Language)Activator.CreateInstance(t)).ToList();
        }

        /// <summary>
        /// Return the language class from its name.
        /// </summary>
        /// <returns></returns>
        public static Language GetLanguage(string languageName)
        {
            return typeof(Language).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(Language))).Select(t => (Language)Activator.CreateInstance(t)).ToList().Where(x => x.GetType().Name.ToLower() == languageName.ToLower()).FirstOrDefault();
        }

    }
}
