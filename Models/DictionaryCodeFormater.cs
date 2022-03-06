using alfa_back.lib.Infrastructure.Concrete;

namespace alfa_back.lib.Models
{
    [BsonCollection("DictionaryFormater")]
    public class DictionaryCodeFormater:Document
    {
        public string Extension { get; set; }
        public string DictionaryFormater { get; set; }
    }
}