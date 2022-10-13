using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Outside;

namespace Inside
{
    public class First:Third
    {
        public int PublicNumber=10;
        private int privateNumber=20;
        public int PrivateNumber{get{return privateNumber;}}

        internal int InternalNumber=30;

        protected int ProtectedNumber=40;

        public int ProtectedinternalNumber{get{return ProtectedInternalNumber;}}
    }
}