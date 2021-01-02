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
        public override void DiChuyen(Point p)
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
        public override void PhongTo(int mul)
        {
            this.p1.x *= mul;
            this.p1.y *= mul;
            this.p2.x *= mul;
            this.p2.y *= mul;
            this.BanKinh = Math.Abs(this.p1.x - this.p2.x);
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
            this.BanKinh = Math.Abs(this.p1.x - this.p2.x);            
        }
        public override void Xuat()
        {
            Console.WriteLine($"{this.Id, -3} | {"Hinh Tron", -15} | {this.p1.ThongTin(), -8} | {this.p2.ThongTin(), -8} | {this.color, -7} | {Math.Round(this.ChuVi(), 2), -6} | {Math.Round(this.DienTich(),2), -9}");
        }
        public override void Menu()
        {
            int chon;
            do {
                Console.Write("\t\t\t |=============================HINH TRON===============================|\n");
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
                            Console.WriteLine($"Chu vi hinh tron {this.Id}: {Math.Round(this.ChuVi(), 2)}");
                            break;
                    case 4:
                            Console.WriteLine($"Dien tich hinh tron {this.Id}: {Math.Round(this.DienTich(), 2)}");
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
                            this.ThongTin();
                            break;
                    case 8:
                            Program.Main(null);
                            break;
                    case 9:
                            Environment.Exit(0);
                            break;
                    default:
                            Console.WriteLine("Khong Hop Le. Xin Nhap Lai");
                            break;
                }
            }
            while(chon != 8 || chon != 9);
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
