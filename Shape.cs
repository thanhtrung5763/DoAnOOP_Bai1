using System;

namespace Polymorphism
{
    public abstract class Shape
    {
        public static int IdSeed = 0;
        protected int iID;
        protected Point P1;
        protected Point P2;
        private int iColor;

        public Point p1
        {
            get { return this.P1; }
            set { this.P1 = value; }
        }
        public Point p2
        {
            get { return this.P2; }
            set { this.P2 = value; }
        }
        public int Id {
            get { return this.iID; }
            set { this.iID = value; }
        }
        public int color
        {
            get { return this.iColor; }
            set { this.iColor = value; }
        }
        public Shape()
        {
            this.p1 = new Point();
            this.p2 = new Point();
            this.Id = IdSeed;
            IdSeed++;
        }
        public Shape(Point p1, Point p2, int color)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.color = color;
            this.Id = IdSeed;
            IdSeed++;
        }
        ~Shape()
        {
        }
        
        public virtual void Nhap()
        {
            Console.WriteLine("Nhap toa do diem 1: ");
            this.p1.Nhap();
            Console.WriteLine("Nhap toa do diem 2: ");
            this.p2.Nhap();
            Console.WriteLine("Nhap mau sac: ");
            this.iColor = int.Parse(Console.ReadLine());
        }
        public virtual void Nhap(Point p1, Point p2, int color)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.color = color;
        }
        public virtual void DiChuyen(Point p)
        {
            this.p1.x += p.x;
            this.p2.x += p.x;
            this.p1.y += p.y;
            this.p2.y += p.y;
        }
        public abstract double DienTich();
        public abstract double ChuVi();
        public abstract void Ve();
        public virtual void ThayDoiMau() {
            Console.WriteLine("Nhap mau sac moi: ");
            this.color = int.Parse(Console.ReadLine());
        }
        public abstract void Xuat();
        public virtual void ThongTin() {
            
        }
        public abstract void PhongTo(int mul);
        public abstract void ThuNho(int mul);
        public virtual void Menu() {
            Console.WriteLine("\t\t\t |================================MENU=================================|\n");
            Console.WriteLine("\t\t\t |                            1. Ve                                    |\n");
            Console.WriteLine("\t\t\t |                            2. Di Chuyen                             |\n");
            Console.WriteLine("\t\t\t |                            3. Chu Vi                                |\n");
            Console.WriteLine("\t\t\t |                            4. Dien Tich                             |\n");
            Console.WriteLine("\t\t\t |                            5. Phong To                              |\n");
            Console.WriteLine("\t\t\t |                            6. Thu Nho                               |\n");
            Console.WriteLine("\t\t\t |                            7. Xuat                                  |\n");
            Console.WriteLine("\t\t\t |                            8. Quay Lai                              |\n");
            Console.WriteLine("\t\t\t |                            9. Thoat                                 |\n");
            Console.WriteLine("\t\t\t |===============================CHOOSE================================|\n");
            Console.Write("Ban chon: ");
        }
        public virtual void Menu2() {
            Console.WriteLine("\t\t\t |================================MENU=================================|\n");
            Console.WriteLine("\t\t\t |                            1. Ve                                    |\n");
            Console.WriteLine("\t\t\t |                            2. Di Chuyen                             |\n");
            Console.WriteLine("\t\t\t |                            3. Chu Vi                                |\n");
            Console.WriteLine("\t\t\t |                            4. Dien Tich                             |\n");
            Console.WriteLine("\t\t\t |                            5. Phong To                              |\n");
            Console.WriteLine("\t\t\t |                            6. Thu Nho                               |\n");
            Console.WriteLine("\t\t\t |                            7. Xuat                                  |\n");
            Console.WriteLine("\t\t\t |                            8. Quay Lai                              |\n");
            Console.WriteLine("\t\t\t |                            9. Thoat                                 |\n");
            Console.WriteLine("\t\t\t |===============================CHOOSE================================|\n");
            Console.Write("Ban chon: ");
        }
    }
}