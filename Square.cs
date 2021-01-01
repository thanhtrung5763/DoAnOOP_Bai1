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
        public new void DiChuyen(Point p)
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
        public override void PhongTo(int mul)
        {
            this.p1.x *= mul;
            this.p1.y *= mul;
            this.p2.x *= mul;
            this.p2.y *= mul;
            this.Canh = Math.Abs(this.p1.x - this.p2.x);
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
            this.Canh = Math.Abs(this.p1.x - this.p2.x);
        }
        public override void Xuat()
        {
            Console.WriteLine($"{this.Id, -3} | {"Hinh Vuong", -15} | {this.p1.ThongTin(), -8} | {this.p2.ThongTin(), -8} | {this.color, -7} | {Math.Round(this.ChuVi(), 2), -6} | {Math.Round(this.DienTich(),2), -9}");
        }
        public override void Menu()
        {
            int chon;
            try {
                if(this.p1.x != this.p2.x && this.p1.y != this.p2.y) {
                    do {
                        Console.Write("\t\t\t |=============================HINH VUONG==============================|\n");
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
                                    Console.WriteLine($"Chu vi hinh vuong {this.Id}: {Math.Round(this.ChuVi(), 2)}");
                                    break;
                            case 4:
                                    Console.WriteLine($"Dien tich hinh vuong {this.Id}: {Math.Round(this.DienTich(), 2)}");
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
                            default:
                                    Console.Clear();
                                    Console.WriteLine("Khong Hop Le. Xin Nhap Lai");
                                    break;
                        }
                    }
                    while(chon != 8);
                }
                else
                    throw new Exception("2 diem vua nhap da trung nhau hoac thang hang!!!");
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
    }
}
