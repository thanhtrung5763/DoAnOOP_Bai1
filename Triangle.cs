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
        public override void PhongTo(int mul)
        {
            this.p1.x *= mul;
            this.p1.y *= mul;
            this.p2.x *= mul;
            this.p2.y *= mul;
            changeLengthWidth();
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
            changeLengthWidth();
        }
        public override void Xuat()
        {
            Console.WriteLine($"{this.Id, -3} | {"Hinh Tam Giac", -15} | {this.p1.ThongTin(), -8} | {this.p2.ThongTin(), -8} | {this.color, -7} | {Math.Round(this.ChuVi(), 2), -6} | {Math.Round(this.DienTich(),2), -9}");
        }
        public override void Menu()
        {
            int chon;
            try {
                if(this.p1.x != this.p2.x && this.p1.y != this.p2.y) {   
                    do {
                        Console.Write("\t\t\t |===========================HINH TAM GIAC=============================|\n");
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
                                    Console.WriteLine($"Chu vi hinh tam giac {this.Id}: {Math.Round(this.ChuVi(), 2)}");
                                    break;
                            case 4:
                                    Console.WriteLine($"Dien tich hinh tam giac {this.Id}: {Math.Round(this.DienTich(), 2)}");
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