namespace alfa_back.lib.Models
{
    public class LanguageInfo
    {
        public string LanguageName { get; set; }
        public string Extension { get; set; }
        public int MilisecondsAllowed { get; set; }

        ///the value of this property should be
        ///the main function with the correspondent
        ///test cases and a call to the boilerplate function
        ///at the end, a call to the formater Results Dictionary
        ///should be included
        public string EntryPoint { get; set; }

        public string HeadersAllowed { get; set; }
        public string Boilerplate { get; set; }
    }
}