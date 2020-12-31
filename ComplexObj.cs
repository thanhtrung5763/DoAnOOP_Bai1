using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class ComplexObj : Shape
    {
        private List<Shape> lShape = new List<Shape>();

        public List<Shape> Shape
        {
            get { return this.lShape; }
            set { this.lShape = value; }
        }

        public ComplexObj() : base()
        {
            this.lShape = new List<Shape>();
        }
        public ComplexObj(List<Shape> lShape)
        {
            this.lShape = lShape;
        }
        ~ComplexObj() 
        {

        }
        public override double DienTich()
        {
            double dt = 0;
            foreach (Shape s in lShape)
                dt += s.DienTich();
            return dt;
        }
        public override double ChuVi()
        {
            double cv = 0;
            foreach (Shape s in lShape)
                cv += s.ChuVi();
            return cv;
        }
        public override void Ve()
        {
            foreach(Shape s in lShape)
                s.Ve();
        }
        public override void Xuat()
        {
            foreach (Shape s in lShape)
                s.Xuat();
        }
    }
}
