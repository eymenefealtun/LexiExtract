namespace LexiExtract.Languages
{
    public class English : Language
    {
        //public override string Url => throw new NotImplementedException();

        string mainUrl = "https://raw.githubusercontent.com/eymenefealtun/all-words-in-all-languages/main/English/English-466.553.txt";
        public override string MainUrl
        {
            get
            {
                return mainUrl;
            }
        }


    }
}
