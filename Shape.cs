using System;

namespace Polymorphism
{
    public abstract class Shape
    {
        public static int IdSeed = 0;
        protected int iID;
        protected Point P1;
        protected Point P2;
        private int iColor;

        public Point p1
        {
            get { return this.P1; }
            set { this.P1 = value; }
        }
        public Point p2
        {
            get { return this.P2; }
            set { this.P2 = value; }
        }
        public int Id {
            get { return this.iID; }
            set { this.iID = value; }
        }
        public int color
        {
            get { return this.iColor; }
            set { this.iColor = value; }
        }
        public Shape()
        {
            this.p1 = new Point();
            this.p2 = new Point();
            this.Id = IdSeed;
            IdSeed++;
        }
        public Shape(Point p1, Point p2, int color)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.color = color;
            this.Id = IdSeed;
            IdSeed++;
        }
        ~Shape()
        {
        }
        
        public virtual void Nhap()
        {
            Console.WriteLine("Nhap toa do diem 1: ");
            this.p1.Nhap();
            Console.WriteLine("Nhap toa do diem 2: ");
            this.p2.Nhap();
            Console.WriteLine("Nhap mau sac: ");
            this.iColor = int.Parse(Console.ReadLine());
        }
        public virtual void Nhap(Point p1, Point p2, int color)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.color = color;
        }
        public virtual void DiChuyen(Point p)
        {
            this.p1.x += p.x;
            this.p2.x += p.x;
            this.p1.y += p.y;
            this.p2.y += p.y;
        }
        public abstract double DienTich();
        public abstract double ChuVi();
        public abstract void Ve();
        public virtual void ThayDoiMau() {
            Console.WriteLine("Nhap mau sac moi: ");
            this.color = int.Parse(Console.ReadLine());
        }
        public abstract void Xuat();
        public virtual void ThongTin() {
            Console.WriteLine($"{"", -25}--------------------------------------------------------------------------");
            Console.WriteLine($"{"", -25}STT | Hinh            | Toa Do 1 | Toa Do 2 | Mau Sac | Chu Vi | Dien Tich");
            Console.WriteLine($"{"", -25}--------------------------------------------------------------------------");
        }
        public virtual void PhongTo(int mul) {
            this.p1.x *= mul;
            this.p1.y *= mul;
            this.p2.x *= mul;
            this.p2.y *= mul;
        }

        public virtual void PhongTo() {
            int mul;
            Console.WriteLine("Nhap he so phong to: ");
            mul = int.Parse(Console.ReadLine());
            this.PhongTo(mul);
        }
        public virtual void ThuNho() {
            int div;
            Console.WriteLine("Nhap he so thu nho: ");
            div = int.Parse(Console.ReadLine());

            if(this.p1.x == 0 || this.p1.x / div != 0 
            && (this.p1.y == 0 || this.p1.y / div != 0)
            && (this.p2.x == 0 || this.p2.x / div != 0)
            && (this.p2.y == 0 || this.p2.y / div != 0)) {
                this.p1.x /= div;
                this.p1.y /= div;
                this.p2.x /= div;
                this.p2.y /= div;
            }
            else {
                Console.WriteLine("He So Thu Nho Qua Lon. Xin Nhap Lai");
                this.ThuNho();
            }
        }
        public virtual void Menu() {
            int chon;
            try {
                do {
                    Console.WriteLine($"\t\t\t |================================{this.GetType().Name} MENU=================================|\n");
                    Console.WriteLine($"\t\t\t |                            {"".PadRight(this.GetType().Name.Length - 4, ' ')} 1. Ve                                        |\n");
                    Console.WriteLine($"\t\t\t |                            {"".PadRight(this.GetType().Name.Length - 4, ' ')} 2. Di Chuyen                                 |\n");
                    Console.WriteLine($"\t\t\t |                            {"".PadRight(this.GetType().Name.Length - 4, ' ')} 3. Chu Vi                                    |\n");
                    Console.WriteLine($"\t\t\t |                            {"".PadRight(this.GetType().Name.Length - 4, ' ')} 4. Dien Tich                                 |\n");
                    Console.WriteLine($"\t\t\t |                            {"".PadRight(this.GetType().Name.Length - 4, ' ')} 5. Phong To                                  |\n");
                    Console.WriteLine($"\t\t\t |                            {"".PadRight(this.GetType().Name.Length - 4, ' ')} 6. Thu Nho                                   |\n");
                    Console.WriteLine($"\t\t\t |                            {"".PadRight(this.GetType().Name.Length - 4, ' ')} 7. Xuat                                      |\n");
                    Console.WriteLine($"\t\t\t |                            {"".PadRight(this.GetType().Name.Length - 4, ' ')} 8. Quay Lai                                  |\n");
                    Console.WriteLine($"\t\t\t |                            {"".PadRight(this.GetType().Name.Length - 4, ' ')} 9. Thoat                                     |\n");
                    Console.WriteLine($"\t\t\t |==========================={"".PadRight(this.GetType().Name.Length, '=')}CHOOSE=====================================|\n");
                    Console.Write("Ban chon: ");
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
                                Console.WriteLine($"Chu vi hinh {this.Id}: {Math.Round(this.ChuVi(), 2)}");
                                break;
                        case 4:
                                Console.WriteLine($"Dien tich hinh {this.Id}: {Math.Round(this.DienTich(), 2)}");
                                break;
                        case 5:
                                this.PhongTo();
                                break;
                        case 6:
                                this.ThuNho();
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
                                Console.WriteLine("Vui Long Nhap Lai");
                                break;
                    }
                }
                while(chon != 8 || chon != 9);
            }
            catch(System.FormatException) {
                    Console.Clear();
                    Console.WriteLine("Vui Long Nhap Chu So");
                    this.Menu();
            } 
        }
    }
}