using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Order
    {
        public int Id { get; set; }
        //public DateTime Date { get; set; }
        public string Number { get; set; }

        public IList<Material> Materials { get; set; }


        public Order()
        {
            Materials = new List<Material>();
        }

    }
}
