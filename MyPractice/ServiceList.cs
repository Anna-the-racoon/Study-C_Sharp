using System.Collections.Generic;
using System.Linq;

namespace MyPractice
{
    class ServiceList
    {

        public IList<int> GetInts()
        {

            var ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

            var result = ints.Where(p => p > 3);


            //var result2 = ints.

            return (IList<int>)result;
        }


    }
}
