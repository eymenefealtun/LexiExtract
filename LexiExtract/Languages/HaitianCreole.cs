namespace LexiExtract.Languages
{
    public class HaitianCreole : Language
    {

        public override string[] GetAllWords()
        {
            return Helpers.ExtractArray(Helpers.GetMainUrl("Haitian%20Creole"));
        }
        public override Task<string[]> GetAllWordsAsync()
        {
            return Helpers.ExtractArrayAsync(Helpers.GetMainUrl("Haitian%20Creole"));
        }
    }

}
