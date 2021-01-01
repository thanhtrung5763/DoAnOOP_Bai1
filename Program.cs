using System;
using System.Collections.Generic;
namespace Polymorphism
{
    
    public class Program
    {
        public static void Main(string[] args)
        {
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
