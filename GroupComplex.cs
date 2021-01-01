using System;
using System.Collections.Generic;

namespace Polymorphism
{
    public class GroupComplex {
        private List<ComplexObj> lComp = new List<ComplexObj>();
        public List<ComplexObj> Comp
        {
            get { return this.lComp; }
            set { this.lComp = value; }
        }
        public GroupComplex(){

        }
        ~GroupComplex()
        {
        }
        public void Xuat()
        {
            for(int i = 0; i < lComp.Count; i++) {
                Console.WriteLine($"-----------------------------COMPLEX {i}------------------------------------");
                lComp[i].Xuat();
            }
        }
    }
}