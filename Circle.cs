using System;

namespace Polymorphism
{
    public class Circle : Shape
    {
        protected int iBanKinh;
        public int BanKinh
        {
            get { return this.iBanKinh; }
            set { this.iBanKinh = value; }
        }
        public Circle() : base()
        {

        }
        public Circle(Point p1, Point p2, int color) : base(p1, p2, color)
        {
            this.BanKinh = Math.Abs(this.p1.x - this.p2.x);
        }
        public override void Nhap()
        {
            Console.WriteLine("Nhap thong so hinh tron...");
            base.Nhap();
            this.BanKinh = Math.Abs(this.p1.x - this.p2.x);
        }
        public override void Nhap(Point p1, Point p2, int color)
        {
            Console.WriteLine("Nhap thong so hinh tron...");
            base.Nhap(p1, p2, color);
            this.BanKinh = Math.Abs(this.p1.x - this.p2.x);
        }
        public new void DiChuyen(Point p)
        {
            base.DiChuyen(p);
        }
        public override double DienTich()
        {
            return 3.14 * this.BanKinh * this.BanKinh;
        }
        public override double ChuVi()
        {
            return 0.5 * 3.14 * this.BanKinh;
        }
        public override void Ve()
        {
            Console.WriteLine("Ve hinh tron");
        }
        public override void ThayDoiMau()
        {
            base.ThayDoiMau();
        }
        public override void Xuat()
        {
            Console.WriteLine($"Hinh Tron\tToa Do 1: {this.p1.ThongTin()}\tToa do 2: {this.p2.ThongTin()}\tMau Sac: {this.color}\tChu Vi: {Math.Round(this.ChuVi(), 2)}\tDien Tich: {Math.Round(this.DienTich(), 2)}");
        }
    }
}
