using System;
using System.Collections.Generic;
using System.Text;

namespace AdoNet
{
    //данный класс создан, для того, чтоб было лечче делать связку с другими объектами из других классов
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
