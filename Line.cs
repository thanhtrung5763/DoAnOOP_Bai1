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
            Console.WriteLine($"{this.Id, -3} | {"Doan Thang", -15} | {this.p1.ThongTin(), -8} | {this.p2.ThongTin(), -8} | {this.color, -7} | {Math.Round(this.ChuVi(), 2), -6} | {Math.Round(this.DienTich(),2), -9}");
        }
        public override void Menu()
        {
            int chon;
            try {
                if(!(this.p1.x == this.p2.x && this.p1.y == this.p1.y)) {
                    do {
                        Console.Write("\t\t\t |=============================DOAN THANG==============================|\n");
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
                                    Console.WriteLine($"Chu vi doan thang {this.Id}: 0");
                                    break;
                            case 4:
                                    Console.WriteLine($"Dien tich doan thang {this.Id}: 0");
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
                                    Console.Clear();
                                    this.ThongTin();
                                    break;
                            case 8:
                                    Console.Clear();
                                    Program.Main(null);
                                    break;
                            case 9:
                                    Environment.Exit(0);
                                    break;
                            default:
                                    Console.Clear();
                                    Console.WriteLine("Khong Hop Le. Xin Nhap Lai");
                                    break;
                        }
                    }
                    while(chon != 8 || chon != 9);
                }
                else
                    throw new Exception("2 diem vua nhap trung nhau!!!");
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }
        }
        public override void ThongTin()
        {
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("STT | Hinh            | Toa Do 1 | Toa Do 2 | Mau Sac | Chu Vi | Dien Tich");
            Console.WriteLine("--------------------------------------------------------------------------");
            this.Xuat();
        }
        public override void PhongTo(int mul)
        {
            this.p1.x *= mul;
            this.p1.y *= mul;
            this.p2.x *= mul;
            this.p2.y *= mul;
            this.dDai = Math.Sqrt(Math.Pow(this.p1.x - this.p2.x, 2) + Math.Pow(this.p1.y - this.p2.y, 2));
        }
        public override void ThuNho(int div)
        {
            try {
                if(this.p1.x == 0 || this.p1.x / div != 0)
                    this.p1.x /= div;
                else throw new Exception("He So Thu Nho Qua Lon");
                if(this.p1.y == 0 || this.p1.y / div != 0)
                    this.p1.y /= div;
                else throw new Exception("He So Thu Nho Qua Lon");
                if(this.p2.x == 0 || this.p2.x / div != 0)
                    this.p2.x /= div;
                else throw new Exception("He So Thu Nho Qua Lon");
                if(this.p2.y == 0 || this.p2.y / div != 0)
                    this.p2.y /= div;
                else throw new Exception("He So Thu Nho Qua Lon");
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }
            this.dDai = Math.Sqrt(Math.Pow(this.p1.x - this.p2.x, 2) + Math.Pow(this.p1.y - this.p2.y, 2));
        }
    }
}