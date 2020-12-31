using System;

namespace Polymorphism
{
    public class Rectangle : Shape
    {
        protected int iChieuDai;
        protected int iChieuRong;
        public int ChieuDai
        {
            get { return this.iChieuDai; }
            set { this.iChieuDai = value; }
        }
        public int ChieuRong
        {
            get { return this.iChieuRong; }
            set { this.iChieuRong = value; }
        }

        public Rectangle() : base()
        {

        }
        public Rectangle(Point p1, Point p2, int color) : base(p1, p2, color)
        {
            SetupLengthWidth();
        }
        public void SetupLengthWidth()
        {
            this.ChieuDai = Math.Abs(this.p1.x - this.p2.x);
            this.ChieuRong = Math.Abs(this.p1.y - this.p2.y);
            if (this.ChieuDai < this.ChieuRong)
            {
                int temp = this.ChieuDai;
                this.ChieuDai = this.ChieuRong;
                this.ChieuRong = temp;
            }
        }

        public override void Nhap()
        {
            Console.WriteLine("Nhap thong so hinh chu nhat...");
            base.Nhap();
            SetupLengthWidth();
        }
        public override void Nhap(Point p1, Point p2, int color)
        {
            Console.WriteLine("Nhap thong so hinh chu nhat...");
            base.Nhap(p1, p2, color);
            SetupLengthWidth();
        }
        public new void DiChuyen(Point p)
        {
            base.DiChuyen(p);
        }
        public override double DienTich()
        {
            return ChieuDai * ChieuRong;
        }
        public override double ChuVi()
        {
            return (ChieuDai + ChieuRong) * 2;
        }
        public override void Ve() {
            Console.WriteLine("Ve hinh chu nhat");
        }
        public override void ThayDoiMau()
        {
            base.ThayDoiMau();
        }
        public override void Xuat()
        {
            Console.WriteLine($"{this.Id, -3} | {"Hinh Chu Nhat", -15} | {this.p1.ThongTin(), -8} | {this.p2.ThongTin(), -8} | {this.color, -7} | {Math.Round(this.ChuVi(), 2), -6} | {Math.Round(this.DienTich(),2), -9}");
        }
    }
}
