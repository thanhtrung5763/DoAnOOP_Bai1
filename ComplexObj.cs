using System;
using System.Collections.Generic;

namespace Polymorphism
{
    public class ComplexObj : Shape
    {
        protected List<Shape> lShape = new List<Shape>();

        public List<Shape> Shape
        {
            get { return this.lShape; }
            set { this.lShape = value; }
        }

        public ComplexObj() : base()
        {
            IdSeed--;
            this.lShape = new List<Shape>();
        }
        public ComplexObj(List<Shape> lShape)
        {
            this.lShape = lShape;
        }
        ~ComplexObj() 
        {

        }
        public override void Nhap() {
            int soHinh = 0;
            Console.WriteLine("Nhap so luong doan thang: ");
            soHinh = int.Parse(Console.ReadLine());
            for(int i = 0; i < soHinh; i++) {
                try {
                    Line temp = new Line();
                    temp.Nhap();
                    if(!(temp.p1.x == temp.p2.x && temp.p1.y == temp.p1.y))   
                        this.lShape.Add(temp);
                    else {
                        IdSeed--;
                        throw new Exception("2 diem vua nhap trung nhau!!!");
                    }
                }
                catch(Exception e) {
                    Console.WriteLine(e.Message);
                }
                
            }
            Console.WriteLine("Nhap so luong hinh vuong: ");
            soHinh = int.Parse(Console.ReadLine());
            for(int i = 0; i < soHinh; i++) {
                try {
                    Square temp = new Square();
                    temp.Nhap();
                    if(temp.p1.x != temp.p2.x && temp.p1.y != temp.p2.y && Math.Abs(temp.p1.x - temp.p2.x) == Math.Abs(temp.p1.y - temp.p2.y))   
                        this.lShape.Add(temp);
                    else {
                        IdSeed--;
                        throw new Exception("2 diem vua nhap da trung nhau hoac thang hang!!!");
                    }
                }
                catch(Exception e) {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("Nhap so luong hinh tam giac: ");
            soHinh = int.Parse(Console.ReadLine());
            for(int i = 0; i < soHinh; i++) {
                try {
                    Triangle temp = new Triangle();
                    temp.Nhap();
                    if(temp.p1.x != temp.p2.x && temp.p1.y != temp.p2.y)   
                        this.lShape.Add(temp);
                    else {
                        IdSeed--;
                        throw new Exception("2 diem vua nhap da trung nhau hoac thang hang!!!");
                    }
                }
                catch(Exception e) {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("Nhap so luong hinh tron: ");
            soHinh = int.Parse(Console.ReadLine());
            for(int i = 0; i < soHinh; i++) {
                try {
                    Circle temp = new Circle();
                    temp.Nhap();
                    if(temp.p1.x != temp.p2.x && temp.p1.y != temp.p2.y && Math.Abs(temp.p1.x - temp.p2.x) == Math.Abs(temp.p1.y - temp.p2.y))   
                        this.lShape.Add(temp);
                    else {
                        IdSeed--;
                        throw new Exception("Khong the ve hinh tron voi khung hinh vuong!!!");
                    }
                }
                catch(Exception e) {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("Nhap so luong hinh chu nhat: ");
            soHinh = int.Parse(Console.ReadLine());
            for(int i = 0; i < soHinh; i++) {
                try {
                    Rectangle temp = new Rectangle();
                    temp.Nhap();
                    if(temp.p1.x != temp.p2.x && temp.p1.y != temp.p2.y)   
                        this.lShape.Add(temp);
                    else {
                        IdSeed--;
                        throw new Exception("2 diem trung nhau hoac thang hang!!!");
                    }
                }
                catch(Exception e) {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("Nhap mau sac cho ComplexObj: ");
            this.color = int.Parse(Console.ReadLine());
        }
        public override void DiChuyen(Point p)
        {
            foreach(Shape s in lShape) {
                s.DiChuyen(p);
            }
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
            Console.WriteLine("Ve ComplexObject");
        }
        public override void PhongTo()
        {
            int mul;
            Console.WriteLine("Nhap he so phong to: ");
            mul = int.Parse(Console.ReadLine());
            foreach(Shape s in lShape) {
                s.PhongTo(mul);
            }
        }
        public override void ThuNho()
        {
            bool flag = false;
            int div;
            Console.WriteLine("Nhap he so thu nho: ");
            div = int.Parse(Console.ReadLine());
            foreach(Shape s in lShape) {
                if(s.p1.x == 0 || s.p1.x / div != 0 
                && (s.p1.y == 0 || s.p1.y / div != 0)
                && (s.p2.x == 0 || s.p2.x / div != 0)
                && (s.p2.y == 0 || s.p2.y / div != 0)) {
                    s.p1.x /= div;
                    s.p1.y /= div;
                    s.p2.x /= div;
                    s.p2.y /= div;
                }
                else {
                    flag = true;
                    Console.WriteLine("He So Thu Nho Qua Lon. Xin Nhap Lai");
                    break;
                }
            }
            if(flag)
                ThuNho();
        }
        public override void Menu()
        {
            base.Menu();
        }
        public override void Xuat()
        {
            foreach (Shape s in lShape)
                s.Xuat();
        }
        public override void ThongTin()
        {
            base.ThongTin();
            this.Xuat();
        }

    }
}
