using System.Collections.Generic;
using alfa_back.lib.Infrastructure.Concrete;

namespace alfa_back.lib.Models
{
    [BsonCollection("Problem")]
    public class Problem : Document
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int TimesSolved { get; set; }
        public List<LanguageInfo> LanguageInformation { get; set; }

        public List<TestCaseInfo> TestCasesToDraw { get; set; }
        
        public List<ProgramSolution> Solutions { get; set; }
    }
}