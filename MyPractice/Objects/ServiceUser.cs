using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractice.Objects
{
    public class ServiceUser
    {
        private UserClass userClassRef ;
        private UserSrtucture userSrtuctureVal;

        private UserSrtucture userSrtuctureRef;

        public void Set(UserClass userClassRef, UserSrtucture userSrtuctureVal, ref UserSrtucture userSrtuctureRef)
        {
            this.userClassRef = userClassRef;
            this.userSrtuctureVal = userSrtuctureVal;
            this.userSrtuctureRef = userSrtuctureRef;

            this.userClassRef.SetName("Changed");
            this.userSrtuctureVal.SetName("Changed");
            this.userSrtuctureRef.SetName("Changed");

        }
        public UserClass GetUserClassRef() { return userClassRef; }
        public UserSrtucture GetUserStructureVal() { return userSrtuctureVal; }
        public UserSrtucture GetUserStructureRef() { return userSrtuctureRef; }

    }
}
