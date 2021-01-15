using System;

namespace Polymorphism
{
    public class Line : Shape
    {
        private double dDai;
        public double Dai {
            get { return this.dDai; }
            set { this.dDai = value; }
        }
        public Line() : base()
        {

        }
        public Line(Point p1, Point p2, int color) : base(p1, p2, color)
        {
            this.dDai = Math.Sqrt(Math.Pow(this.p1.x - this.p2.x, 2) + Math.Pow(this.p1.y - this.p2.y, 2));
        }
        ~Line()
        {

        }
        public override void Nhap()
        {
            Console.WriteLine("Nhap thong so doan thang...");
            base.Nhap();
            this.dDai = Math.Sqrt(Math.Pow(this.p1.x - this.p2.x, 2) + Math.Pow(this.p1.y - this.p2.y, 2));
        }
        public override void Nhap(Point p1, Point p2, int color)
        {
            Console.WriteLine("Nhap thong so doan thang...");
            base.Nhap(p1, p2, color);
            this.dDai = Math.Sqrt(Math.Pow(this.p1.x - this.p2.x, 2) + Math.Pow(this.p1.y - this.p2.y, 2));
        }
        public override void DiChuyen(Point p)
        {
            base.DiChuyen(p);
        }
        public override double DienTich()
        {
            return 0;
        }
        public override double ChuVi()
        {
            return 0;
        }
        public override void Ve()
        {
            Console.WriteLine("Ve doan thang");
        }
        public override void ThayDoiMau()
        {
            base.ThayDoiMau();
        }
        public override void Xuat()
        {
            Console.WriteLine($"{"", -25}{this.Id, -3} | {"Doan Thang", -15} | {this.p1.ThongTin(), -8} | {this.p2.ThongTin(), -8} | {this.color, -7} | {Math.Round(this.ChuVi(), 2), -6} | {Math.Round(this.DienTich(),2), -9}");
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
        public override void PhongTo()
        {
            base.PhongTo();
            this.dDai = Math.Sqrt(Math.Pow(this.p1.x - this.p2.x, 2) + Math.Pow(this.p1.y - this.p2.y, 2));
        }
        public override void ThuNho()
        {
            base.ThuNho();
            this.dDai = Math.Sqrt(Math.Pow(this.p1.x - this.p2.x, 2) + Math.Pow(this.p1.y - this.p2.y, 2));
        }
    }
}