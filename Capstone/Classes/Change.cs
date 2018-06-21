using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class Change
    {
        public int Quarters { get; set; }
        public int Dimes { get; set; }
        public int Nickels { get; set; }

        public Change()
        {
            this.Quarters = 0;
            this.Dimes = 0;
            this.Nickels = 0;
        }

    }
}
