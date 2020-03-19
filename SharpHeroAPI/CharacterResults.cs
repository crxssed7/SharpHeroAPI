using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpHeroAPI
{
    public class CharacterResults
    {
        public string response { get; set; }
        public string resultsfor { get; set; }
        public List<Character> results { get; set; }
    }
}
