using System;
using System.Collections.Generic;

namespace Polymorphism
{
    public static class GroupMerDiv {
        private static List<Graphic> lGra = new List<Graphic>();
        public static List<Graphic> Gra {
            get { return GroupMerDiv.lGra; }
            set { GroupMerDiv.lGra = value; }
        }

        static GroupMerDiv()
        {

        }
    }
}