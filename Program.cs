using System;
using System.Collections.Generic;
namespace Polymorphism
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 2);
            Point p2 = new Point(3, 4);
            Point p3 = new Point(2, 1);
            Point p4 = new Point(5, 3);
            Console.WriteLine(p1.ThongTin());
            Console.WriteLine(p2.ThongTin());
            Line l1 = new Line(p1, p2, 0);
            Line l2 = new Line();
            l2.Nhap();
            Rectangle r1 = new Rectangle(p3, p1, 1);
            Rectangle r2 = new Rectangle();
            r2.Nhap();
            Triangle t1 = new Triangle(p1, p4, 1);
            Triangle t2 = new Triangle();
            t2.Nhap();
            Square s1 = new Square(p3, p2, 3);
            Square s2 = new Square();
            s2.Nhap();
            List<Shape> lShape = new List<Shape>();
            lShape.Add(l1);
            lShape.Add(l2);
            lShape.Add(r1);
            lShape.Add(r2);
            lShape.Add(t1);
            lShape.Add(t2);
            lShape.Add(s1);
            lShape.Add(s2);
            ComplexObj c1 = new ComplexObj(lShape);
            Graphic g1 = new Graphic(lShape);

            //Console.WriteLine(c1.DienTich());
            //Console.WriteLine(c1.ChuVi());
            // c1.ThayDoiMau();
            //c1.Ve();
            //c1.Xuat();
        }
    }
}
