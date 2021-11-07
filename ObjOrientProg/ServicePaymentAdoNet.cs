using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjOrientProg
{
    public class ServicePaymentAdoNet : StrviceBace, IServicePayment
    {
        public string Pay(IPayable method)
        {
            return $"Ado.Net {method.Execute()}";
        }
    }
}
