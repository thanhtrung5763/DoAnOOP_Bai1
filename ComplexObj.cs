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
                    else
                        throw new Exception("2 diem vua nhap trung nhau!!!");
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
                    else
                        throw new Exception("2 diem vua nhap da trung nhau hoac thang hang!!!");
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
                    else
                        throw new Exception("2 diem vua nhap da trung nhau hoac thang hang!!!");
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
                    else
                        throw new Exception("Khong the ve hinh tron voi khung hinh vuong!!!");
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
                    else
                        throw new Exception("2 diem trung nhau hoac thang hang!!!");
                }
                catch(Exception e) {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("Nhap mau sac cho ComplexObj: ");
            this.color = int.Parse(Console.ReadLine());
        }
        public virtual void TaoKhung() {
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
        public override void PhongTo(int mul)
        {
            foreach(Shape s in lShape) {
                s.PhongTo(mul);
            }
            this.p1.x *= mul;
            this.p1.y *= mul;
            this.p2.x *= mul;
            this.p2.y *= mul;
        }
        public override void ThuNho(int div)
        {
            foreach(Shape s in lShape) {
                s.ThuNho(div);
            }
            try {
                if(this.p1.x / div != 0)
                    this.p1.x /= div;
                else throw new Exception("He So Thu Nho Qua Lon");
                if(this.p1.y / div != 0)
                    this.p1.y /= div;
                else throw new Exception("He So Thu Nho Qua Lon");
                if(this.p2.x / div != 0)
                    this.p2.x /= div;
                else throw new Exception("He So Thu Nho Qua Lon");
                if(this.p2.y / div != 0)
                    this.p2.y /= div;
                else throw new Exception("He So Thu Nho Qua Lon");
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }
        }
                public override void Menu()
        {
            int chon;
            do {
                Console.Write("\t\t\t |===========================COMPLEX OBJECT============================|\n");
                base.Menu();
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
                            Console.WriteLine(this.ChuVi());
                            break;
                    case 4:
                            Console.WriteLine(this.DienTich());
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
                            Program.Main(null);
                            break;
                    default:
                            Console.Clear();
                            Console.WriteLine("Khong Hop Le. Xin Nhap Lai");
                            break;
                }
            }
            while(chon != 8);
        }
        public override void Xuat()
        {
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("STT | Hinh            | Toa Do 1 | Toa Do 2 | Mau Sac | Chu Vi | Dien Tich");
            Console.WriteLine("--------------------------------------------------------------------------");
            foreach (Shape s in lShape)
                s.Xuat();
        }

    }
}
