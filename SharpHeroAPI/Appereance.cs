using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpHeroAPI
{
    public class Appearance
    {
        public string gender { get; set; }
        public string race { get; set; }
        public List<string> height { get; set; }
        public List<string> weight { get; set; }
        public string eyecolor { get; set; }
        public string haircolor { get; set; }
    }
}
