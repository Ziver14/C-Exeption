using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exeption
{
    public class Bancrupt:Exception
    {
        public Bancrupt(string msg): base(msg) 
        {
            
        }
    }
}
