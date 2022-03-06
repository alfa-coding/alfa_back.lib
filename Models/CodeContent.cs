namespace alfa_back.lib.Models
{
    public class CodeContent
    {
        /*
        CodeContent code_elements = new CodeContent(){
                    EntryPoint=entryFromProblemText,
                    Header=headersText,
                    DictionaryOutputs=dictionarOutputText,
                    SolutionFunction=userSolution
                };
        */
        public string EntryPoint { get; set; }
        public string Header { get; set; }
        public string DictionaryOutputs { get; set; }
        public string SolutionFunction { get; set; }
        public string Extension { get; set; }
    }
}