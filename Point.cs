using System;

namespace Polymorphism
{
    public class Point
    {
        protected int ix;
        protected int iy;

        public int x
        {
            get { return this.ix; }
            set { this.ix = value; }
        }
        public int y
        {
            get { return this.iy; }
            set { this.iy = value; }
        }
        public Point()
        {
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap x: ");
            this.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap y: ");
            this.y = int.Parse(Console.ReadLine());
        }
        public void Nhap(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public string ThongTin()
        {
            string s = string.Format("({0}, {1})", this.x, this.y);
            return s;
        }
    }
}