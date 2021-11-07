using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjOrientProg
{
 
    
    public class ServicePaymentEf : StrviceBace<Payment, int>, IServicePayment
    {

        public override void Delete(int id)
        {
            
        }

        public string Pay(IPayable method)
        {
            return $"EF {method.Execute()}";
        }

        public string DeleteAll(int id)
        {
            return "A";
        }



    }
}
