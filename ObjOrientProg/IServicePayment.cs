using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjOrientProg
{
    interface IServicePayment
    {
        string Pay(IPayable method);

    }
}
