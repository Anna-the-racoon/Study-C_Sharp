using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractice
{
    public class UserClass
    {
        public UserClass(string name)
        {
            this.name = name;
        }

        public UserClass Papa { get => new UserClass("name"); }
        public UserClass Mother { get => new UserClass("name"); }
        public ICollection<UserClass> Children { get => new List<UserClass>(); }
        public ICollection<UserClass> Partners { get => new List<UserClass>(); }


        private string name;

        public string GetName() { return name; }
        public void SetName(string name) { this.name = name; }
    }
}
