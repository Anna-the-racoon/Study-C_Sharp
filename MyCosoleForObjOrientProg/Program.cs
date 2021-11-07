using MyPractice;
using MyPractice.Objects;
using ObjOrientProg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCosoleForObjOrientProg
{
    class Program
    {
        static void Main(string[] args)
        {

            //var service = new ServicePaymentEf();
            //var status1 = service.Pay(new Cash());
            //Console.WriteLine($"Статус оплаты - {status1}");
            //var status2 = service.Pay(new BankCard());
            //Console.WriteLine($"Статус оплаты - {status2}");

            //var payments = service.Get();

            ////service.Create("bup");


            //Console.ReadLine();





            /*byte var1 = 250;
            byte var2 = 150;
            try
            {
                byte sum = (byte)(var1 + var2);
                Console.WriteLine("Сумма: {0}", sum);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }*/

            var classRef1 = new UserClass("Value");
            var structureVal1 = new UserSrtucture("Value");
            var structureRef1 = new UserSrtucture("Value");


            var service = new ServiceUser();
            service.Set(classRef1, structureVal1, ref structureRef1);

            var classRef2 = service.GetUserClassRef();
            var structureVal2 = service.GetUserStructureVal();
            var structureRef2 = service.GetUserStructureRef();

            var nameClassRef = classRef2.GetName();
            var nameStrucVal = structureVal2.GetName();
            var nameStrucRef = structureRef2.GetName();


            Console.ReadLine();

        }
    }
}
