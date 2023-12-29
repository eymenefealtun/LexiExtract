namespace LexiExtract.Languages
{
    public class ScotsGaelic : Language
    {

        public override string[] GetAllWords()
        {
            return Helpers.ExtractArray(Helpers.GetMainUrl("Scots%20Gaelic"));
        }
        public override Task<string[]> GetAllWordsAsync()
        {
            return Helpers.ExtractArrayAsync(Helpers.GetMainUrl("Scots%20Gaelic"));
        }
    }

}
