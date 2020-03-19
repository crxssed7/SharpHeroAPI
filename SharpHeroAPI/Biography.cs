using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpHeroAPI
{
    public class Biography
    {
        public string fullname{ get; set; }
        public string alteregos { get; set; }
        public List<string> aliases { get; set; }
        public string placeofbirth { get; set; }
        public string firstappearance { get; set; }
        public string publisher { get; set; }
        public string alignment { get; set; }
    }
}
