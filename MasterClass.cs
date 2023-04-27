using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finals
{
    //creating inheritance class
    internal class MasterClass
    {
        public string name { get; set; }

        public string description { get; set; }

        public string cost { get; set; }

        public string mass { get; set; }
      
        public List<string> films { get; set; }

        public List<string> listdata { get; set; }

        //creating a polymorphic function
        public static string Compare(string cost, string mass) 
        {
            //cost/mass
            int ratio = (int)(Convert.ToInt64(cost) / Convert.ToInt64(mass));      
        return Convert.ToString(ratio);
            
        }


    }
}
