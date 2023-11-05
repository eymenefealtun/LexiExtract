namespace LexiExtract
{
    public abstract class Language
    {
        public abstract string[] GetAllWords();
        public abstract Task<string[]> GetAllWordsAsync();
    }
}
