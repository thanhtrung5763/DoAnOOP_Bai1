using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Graphic
    {
        private List<Shape> lShape = new List<Shape>();
        public List<Shape> Shape
        {
            get { return this.lShape; }
            set { this.lShape = value; }
        }
        public Graphic()
        {
        }
        ~Graphic()
        {
        }
        public Graphic(List<Shape> lShape)
        {
            this.lShape = lShape;
        }
        public void merge(Point p1, Point p2)
        {
            foreach (Shape s in lShape)
            {
                s.p1 = p1;
                s.p2 = p2;
            }
        }
        public void divide(Point p1, Point p2)
        {
            foreach (Shape s in lShape)
            {
                s.p1 = p1;
                s.p2 = p2;
            }
        }
    }
}