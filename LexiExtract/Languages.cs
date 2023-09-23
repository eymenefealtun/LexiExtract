namespace LexiExtract
{
    public static class Languages
    {

        public enum languages
        {
            Arabic,
            Armenian,
            Azerbaijani,
            Bulgarian,
            Chinese,
            English,
            Finnish,
            French,
            Georgian,
            German,
            Greek,
            Hebrew,
            Hindi,
            Italian,
            Kurdish,
            Persian,
            Portuguese,
            Romanian,
            Serbian,
            Spanish,
            Swedish,
            Turkish,
            Vietnamese
        }

        internal static Dictionary<languages, string> mainWords = new Dictionary<languages, string>() { };


    }
}
