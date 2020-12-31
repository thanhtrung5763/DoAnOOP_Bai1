using System;

namespace Polymorphism
{
    public abstract class Shape
    {
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
        public int color
        {
            get { return this.iColor; }
            set { this.iColor = value; }
        }
        public Shape()
        {
            this.p1 = new Point();
            this.p2 = new Point();
        }
        public Shape(Point p1, Point p2, int color)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.color = color;
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
        public void DiChuyen(Point p)
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

    }
}