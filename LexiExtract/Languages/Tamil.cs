﻿namespace LexiExtract.Languages
{
    public class Tamil : Language
    {

        public override string[] GetAllWords()
        {
            return Helpers.ExtractArray(Helpers.GetMainUrl(this.GetType().Name));
        }
        public override Task<string[]> GetAllWordsAsync()
        {
            return Helpers.ExtractArrayAsync(Helpers.GetMainUrl(this.GetType().Name));
        }
    }

}
