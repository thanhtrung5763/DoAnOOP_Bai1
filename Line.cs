using System;

namespace Polymorphism
{
    public class Line : Shape
    {

        public Line() : base()
        {

        }
        public Line(Point p1, Point p2, int color) : base(p1, p2, color)
        {

        }
        ~Line()
        {

        }
        public override void Nhap()
        {
            Console.WriteLine("Nhap thong so doan thang...");
            base.Nhap();
        }
        public override void Nhap(Point p1, Point p2, int color)
        {
            Console.WriteLine("Nhap thong so doan thang...");
            base.Nhap(p1, p2, color);
        }
        public new void DiChuyen(Point p)
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
            Console.WriteLine($"{this.Id, -3} | {"Doan Thang", -15} | {this.p1.ThongTin(), -8} | {this.p2.ThongTin(), -8} | {this.color, -7} | {Math.Round(this.ChuVi(), 2), -6} | {Math.Round(this.DienTich(),2), -9}");
        }
    }
}