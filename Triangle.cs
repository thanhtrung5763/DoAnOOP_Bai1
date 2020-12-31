using System;

namespace Polymorphism
{
    public class Triangle : Shape
    {
        protected int iDay;
        protected int iCao;
        public int Day
        {
            get { return iDay; }
            set { this.iDay = value; }
        }
        public int Cao
        {
            get { return this.iCao; }
            set { this.iCao = value; }
        }

        public Triangle() : base()
        {

        }
        public Triangle(Point p1, Point p2, int color) : base(p1, p2, color)
        {
            changeLengthWidth();
        }
        public void changeLengthWidth()
        {
            this.Day = Math.Abs(this.p1.x - this.p2.x);
            this.Cao = Math.Abs(this.p1.y - this.p2.y);
        }
        public override void Nhap()
        {
            Console.WriteLine("Nhap thong so hinh tam giac...");
            base.Nhap();
            changeLengthWidth();
        }
        public override void Nhap(Point p1, Point p2, int color)
        {
            Console.WriteLine("Nhap thong so hinh tam giac...");
            base.Nhap(p1, p2, color);
            changeLengthWidth();
        }
        public new void DiChuyen(Point p)
        {
            base.DiChuyen(p);
            changeLengthWidth();
        }
        public override double DienTich()
        {
            return this.Day * this.Cao / 2.0;
        }
        public override double ChuVi()
        {
            return this.Day + this.Cao + Math.Sqrt(Math.Pow(this.Day, 2) + Math.Pow(this.Cao, 2));
        }
        public override void Ve()
        {
            Console.WriteLine("Ve hinh tam giac");
        }
        public override void ThayDoiMau()
        {
            base.ThayDoiMau();
        }
        public override void Xuat()
        {
            Console.WriteLine($"Hinh Tam Giac\tToa Do 1: {this.p1.ThongTin()}\tToa do 2: {this.p2.ThongTin()}\tMau Sac: {this.color}\tChu Vi: {Math.Round(this.ChuVi(), 2)}\tDien Tich: {Math.Round(this.DienTich(), 2)}");
        }
    }
}