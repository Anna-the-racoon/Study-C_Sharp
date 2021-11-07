using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjOrientProg
{
    public class Cash : IPayable
    {
        public string Execute()
        {
            return "Оплачено наличными"; 
        }
    }
}
