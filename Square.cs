using System;

namespace Polymorphism
{
    public class Square : Shape
    {
        protected int iCanh;
        public int Canh
        {
            get { return this.iCanh; }
            set { this.iCanh = value; }
        }
        public Square() : base()
        {

        }
        public Square(Point p1, Point p2, int color) : base(p1, p2, color)
        {
            this.Canh = Math.Abs(this.p1.x - this.p2.x);
        }
        public override void Nhap()
        {
            Console.WriteLine("Nhap thong so hinh vuong...");
            base.Nhap();
            this.Canh = Math.Abs(this.p1.x - this.p2.x);
        }
        public override void Nhap(Point p1, Point p2, int color)
        {
            Console.WriteLine("Nhap thong so hinh vuong...");
            base.Nhap(p1, p2, color);
            this.Canh = Math.Abs(this.p1.x - this.p2.x);
        }
        public override void DiChuyen(Point p)
        {
            base.DiChuyen(p);
        }
        public override double DienTich()
        {
            return this.Canh * this.Canh;
        }
        public override double ChuVi()
        {
            return this.Canh * 4;
        }
        public override void Ve()
        {
            Console.WriteLine("Ve hinh vuong");
        }
        public override void ThayDoiMau()
        {
            base.ThayDoiMau();
        }
        public override void PhongTo()
        {
            base.PhongTo();
            this.Canh = Math.Abs(this.p1.x - this.p2.x);
        }
        public override void ThuNho()
        {
            base.ThuNho();
            this.Canh = Math.Abs(this.p1.x - this.p2.x);
        }
        public override void Xuat()
        {
            Console.WriteLine($"{"", -25}{this.Id, -3} | {"Hinh Vuong", -15} | {this.p1.ThongTin(), -8} | {this.p2.ThongTin(), -8} | {this.color, -7} | {Math.Round(this.ChuVi(), 2), -6} | {Math.Round(this.DienTich(),2), -9}");
        }
        public override void Menu()
        {
            base.Menu();
        }
        public override void ThongTin()
        {
            base.ThongTin();
            this.Xuat();
        }
    }
}
