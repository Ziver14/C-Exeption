using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exeption
{
    public class UnderRageExeption:Exception
    {
        public UnderRageExeption(string msg) : base(msg) { }
       
        
    }
}
