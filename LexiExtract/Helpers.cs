using static LexiExtract.Languages;

namespace LexiExtract
{
    internal static class Helpers
    {
        private static string baseUrl = "https://raw.githubusercontent.com/eymenefealtun/all-words-in-all-languages/main/";

        public static string GetUrl(languages language, Dictionary<languages, string> source)
        {
            return source.Where(x => x.Key == language).FirstOrDefault().Value;
        }

        public static void SetMainSourceDictionary()
        {
            foreach (var key in Enum.GetValues(typeof(languages)).Cast<languages>())
                mainWords.Add(key, GetMainName(key) + ".txt");
        }


        private static string GetMainName(languages language)
        {
            return baseUrl + $"{language}/{language}";
        }

    }
}
