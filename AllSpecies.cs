using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finals
{
    internal class AllSpecies
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }

        //The rest of the species are stored in the below list
        public List<Species> results { get; set; }
    }
}

