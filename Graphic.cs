using System;
using System.Collections.Generic;

namespace Polymorphism
{
    public class Graphic: ComplexObj
    {
        public Graphic(): base()
        {
        }
        ~Graphic()
        {
        }
        public Graphic(List<Shape> lShape)
        {
            this.lShape = lShape;
        }
        public void merge(ComplexObj cmp)
        {
            int soHinh = 0;
            int Id;
            int idx;
            Console.WriteLine("So luong hinh muon merge: ");
            soHinh = int.Parse(Console.ReadLine());
            for(int i = 0; i < soHinh; i++) {
                bool flag = true;
                while(flag) {
                    Console.WriteLine("Nhap Id hinh muon merge: ");
                    Id = int.Parse(Console.ReadLine());
                    idx = cmp.Shape.FindIndex(x => x.Id == Id);
                    if(idx != -1) {
                        this.lShape.Add(cmp.Shape[idx]);
                        flag = false;
                    }
                    else {
                        Console.WriteLine("Khong tim thay hinh!!! Xin Nhap Lai");
                    }
                }
            }
            Console.WriteLine("Da Merge Xong");
            TaoKhung();
        }
        public void divide()
        {
            int soHinh = 0;
            int Id;
            int idx;
            Console.WriteLine("Nhap so hinh muon devide: ");
            soHinh = int.Parse(Console.ReadLine());
            for(int i = 0; i < soHinh; i++) {
                bool flag = true;
                while(flag) {
                    Console.WriteLine("Nhap Id hinh muon devide: ");
                    Id = int.Parse(Console.ReadLine());
                    idx = this.lShape.FindIndex(x => x.Id == Id);
                    if(idx != -1) {
                        this.lShape.RemoveAt(idx);
                        flag = false;
                    }
                    else {
                        Console.WriteLine("Khong tim thay hinh!!! Xin Nhap Lai");
                    }
                }
            }
            Console.WriteLine("Da Devide Xong");
        }
        public override void DiChuyen(Point p)
        {
            base.DiChuyen(p);
        }
        public override double DienTich()
        {
            return Math.Abs(this.p1.x - this.p2.x) * Math.Abs(this.p1.y - this.p2.y);
        }
        public override double ChuVi()
        {
            return (Math.Abs(this.p1.x - this.p2.x) + Math.Abs(this.p1.y - this.p2.y)) * 2;
        }
        public override void Ve()
        {
            Console.WriteLine("Ve MerDivObj");
        }
        public override void PhongTo(int mul)
        {
            base.PhongTo(mul);
            TaoKhung();
        }
        public override void ThuNho(int div)
        {
            base.ThuNho(div);
            TaoKhung();
        }
        public override void Menu()
        {
            int chon;
            do {
                Console.Write("\t\t\t |=============================MER/DIV OBJ=============================|\n");
                base.Menu2();
                chon = int.Parse(Console.ReadLine());
                switch(chon) {
                    case 1:
                            this.Ve();
                            break;
                    case 2:
                            Console.WriteLine("Nhap hoanh do va tung do tinh tien: ");
                            Point p = new Point();
                            p.Nhap();
                            this.DiChuyen(p);
                            break;
                    case 3:
                            Console.WriteLine($"Chu vi MerDivObj: {Math.Round(this.ChuVi(), 2)}");
                            break;
                    case 4:
                            Console.WriteLine($"Dien tich MerDivObj: {Math.Round(this.DienTich(), 2)}");
                            break;
                    case 5:
                            int mul;
                            Console.WriteLine("Nhap he so phong to: ");
                            mul = int.Parse(Console.ReadLine());
                            this.PhongTo(mul);
                            break;
                    case 6:
                            int div;
                            Console.WriteLine("Nhap he so thu nho: ");
                            div = int.Parse(Console.ReadLine());
                            this.ThuNho(div);
                            break;
                    case 7:
                            this.Xuat();
                            break;
                    case 8:
                            Console.Clear();
                            GroupComplex.Menu();
                            break;
                    case 9:
                            Environment.Exit(0);
                            break;
                    default:
                            Console.Clear();
                            Console.WriteLine("Khong Hop Le. Xin Nhap Lai");
                            break;
                }
            }
            while(chon != 8 || chon != 9);
        }
        public void TaoKhung() {
            int x1Max = int.MinValue;
            int x2Min = int.MaxValue;
            int y1Max = int.MinValue;
            int y2Min = int.MaxValue;
            foreach(Shape s in this.lShape) {
                if(s.p1.x > x1Max)
                    x1Max = s.p1.x;
                if(s.p2.x > x1Max)
                    x1Max = s.p2.x;
                if(s.p1.y > y1Max)
                    y1Max = s.p1.y;
                if(s.p2.y > y1Max)
                    y1Max = s.p2.y;
                
            }
            foreach(Shape s in this.lShape) {
                if(s.p1.x != x1Max && s.p2.x != x1Max && s.p1.y != y1Max && s.p2.y != y1Max) {
                    if(s.p1.x < x2Min)
                        x2Min = s.p1.x;
                    if(s.p2.x < x2Min)
                        x2Min = s.p2.x;
                    if(s.p1.y < y2Min)
                        y2Min = s.p1.y;
                    if(s.p2.y < y2Min)
                        y2Min = s.p2.y;
                }
            }
            this.p1.x = x1Max;
            this.p1.y = y1Max;
            this.p2.x = x2Min;
            this.p2.y = y2Min;
        }
        public override void Xuat()
        {
            base.Xuat();
        }
    }
}