using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractice
{
    public struct UserSrtucture
    {
        public UserSrtucture(string name)
        {
            this.name = name;
        }


        private string name;
        public string GetName() { return name; }

        public void SetName(string name) { this.name = name; }

    }
}
