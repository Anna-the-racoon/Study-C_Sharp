using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjOrientProg
{
    public class BankCard : IPayable
    {
     /// <summary>
     /// 
     /// </summary>
     /// <returns></returns>
     public string Execute()
        {
            return "Оплачено банковской картой";
        }
    }
}
