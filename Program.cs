using System;
using System.Collections.Generic;
namespace Polymorphism
{
    
    public class Program
    {
        public static void Main(string[] args)
        {
        //     Point p1 = new Point(1, 2);
        //     Point p2 = new Point(3, 4);
        //     Point p3 = new Point(2, 1);
        //     Point p4 = new Point(5, 3);
        //     Console.WriteLine(p1.ThongTin());
        //     Console.WriteLine(p2.ThongTin());
        //     Line l1 = new Line(p1, p2, 0);
        //     Line l2 = new Line();
        //     l2.Nhap();
        //     Rectangle r1 = new Rectangle(p3, p1, 1);
        //     Rectangle r2 = new Rectangle();
        //     r2.Nhap();
        //     Triangle t1 = new Triangle(p1, p4, 1);
        //     Triangle t2 = new Triangle();
        //     t2.Nhap();
        //     Square s1 = new Square(p3, p2, 3);
        //     Square s2 = new Square();
        //     s2.Nhap();
        //     List<Shape> lShape = new List<Shape>();
        //     lShape.Add(l1);
        //     lShape.Add(l2);
        //     lShape.Add(r1);
        //     lShape.Add(r2);
        //     lShape.Add(t1);
        //     lShape.Add(t2);
        //     lShape.Add(s1);
        //     lShape.Add(s2);
        //     ComplexObj c1 = new ComplexObj(lShape);

            // Console.WriteLine(c1.DienTich());
            // Console.WriteLine(c1.ChuVi());
            // c1.ThayDoiMau();
            //c1.Ve();
            // c1.Xuat();

            // ComplexObj c2 = new ComplexObj();
            // c2.Nhap();
            // Console.WriteLine(c2.DienTich());
            // Console.WriteLine(c2.ChuVi());
            // c2.Xuat();

            // Graphic g1 = new Graphic();
            // g1.merge(c1);
            // g1.divide();
            // g1.Xuat();
            int chon;
            do {
                Console.WriteLine("\n");
                Console.WriteLine("\t\t\t |================================MENU=================================|\n");
                Console.WriteLine("\t\t\t |                            1. Doan Thang                            |\n");
                Console.WriteLine("\t\t\t |                            2. Hinh Chu Nhat                         |\n");
                Console.WriteLine("\t\t\t |                            3. Hinh Tam Giac                         |\n");
                Console.WriteLine("\t\t\t |                            4. Hinh Vuong                            |\n");
                Console.WriteLine("\t\t\t |                            5. Hinh Tron                             |\n");
                Console.WriteLine("\t\t\t |                            6. Nhom Hinh                             |\n");
                Console.WriteLine("\t\t\t |                            7. Tap Cac Nhom Hinh                     |\n");
                Console.WriteLine("\t\t\t |                            8. Thoat                                 |\n");
                Console.WriteLine("\t\t\t |===============================CHOOSE================================|\n");
                Console.Write("Ban chon: ");
                chon = int.Parse(Console.ReadLine());
                switch(chon) {
                    case 1:
                            Line l = new Line();
                            l.Nhap();
                            Console.Clear();
                            if(!(l.p1.x == l.p2.x && l.p1.y == l.p1.y))   
                                l.Menu();
                            else {
                                Console.WriteLine("2 diem vua nhap trung nhau!!!");
                                Program.Main(null);
                            }
                            break;
                    case 2:
                            Rectangle r = new Rectangle();
                            r.Nhap();
                            Console.Clear();
                            if(r.p1.x != r.p2.x && r.p1.y != r.p2.y)   
                                r.Menu();
                            else {
                                Console.WriteLine("2 diem trung nhau hoac thang hang!!!");
                                Program.Main(null);
                            }
                            break;
                    case 3:
                            Triangle t = new Triangle();
                            t.Nhap();
                            Console.Clear();
                            if(t.p1.x != t.p2.x && t.p1.y != t.p2.y)   
                                t.Menu();
                            else {
                                Console.WriteLine("2 diem vua nhap da trung nhau hoac thang hang!!!");
                                Program.Main(null);
                            }
                            break;
                    case 4:
                            Square s = new Square();
                            s.Nhap();
                            Console.Clear();
                            if(s.p1.x != s.p2.x && s.p1.y != s.p2.y && Math.Abs(s.p1.x - s.p2.x) == Math.Abs(s.p1.y - s.p2.y))
                                s.Menu();
                            else {
                                Console.WriteLine("2 diem vua nhap da trung nhau hoac thang hang!!!");
                                Program.Main(null);
                            }
                            break;
                    case 5:
                            Circle c = new Circle();
                            c.Nhap();
                            Console.Clear();
                            if(c.p1.x != c.p2.x && c.p1.y != c.p2.y && Math.Abs(c.p1.x - c.p2.x) == Math.Abs(c.p1.y - c.p2.y))
                                c.Menu();
                            else {
                                Console.WriteLine("Khong the ve hinh tron voi khung hinh vuong!!!");
                                Program.Main(null);
                            }
                            break;
                    case 6:
                            ComplexObj compO = new ComplexObj();
                            compO.Nhap();
                            GroupComplex.Comp.Add(compO);
                            Console.Clear();
                            compO.Menu();
                            break;
                    case 7:
                            compO = new ComplexObj();
                            compO.Nhap();
                            GroupComplex.Comp.Add(compO);
                            GroupComplex.Menu();
                            break;
                    case 8:
                            Console.Clear();
                            break;
                    default:
                            Console.Clear();
                            Console.WriteLine("Khong Hop Le. Xin Nhap Lai");
                            break;
                            
                }
            }
            while(chon < 1 || chon > 8);
            
        }
    }
}
