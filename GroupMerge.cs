using System;
using System.Collections.Generic;

namespace Polymorphism
{
    public static class GroupMerge {
        private static List<MergeObj> lMer = new List<MergeObj>();
        public static List<MergeObj> Mer {
            get { return GroupMerge.lMer; }
            set { GroupMerge.lMer = value; }
        }

        static GroupMerge()
        {

        }
    }
}