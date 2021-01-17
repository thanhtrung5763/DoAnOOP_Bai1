using System;
using System.Collections.Generic;

namespace Polymorphism
{
    public class MergeObj: ComplexObj
    {
        public MergeObj(): base()
        {
        }
        ~MergeObj()
        {
        }
        public MergeObj(List<Shape> lShape)
        {
            this.lShape = lShape;
        }
        public void merge(ComplexObj cmp)
        {
            int soHinh = 0;
            int Id;
            int idx;
            Console.WriteLine("So luong hinh muon merge: ");
            soHinh = int.Parse(Console.ReadLine());
            for(int i = 0; i < soHinh; i++) {
                bool flag = true;
                while(flag) {
                    Console.WriteLine("Nhap Id hinh muon merge: ");
                    Id = int.Parse(Console.ReadLine());
                    idx = cmp.Shape.FindIndex(x => x.Id == Id);
                    if(idx != -1) {
                        this.lShape.Add(cmp.Shape[idx]);
                        flag = false;
                    }
                    else {
                        Console.WriteLine("Khong tim thay hinh!!! Xin Nhap Lai");
                    }
                }
            }
            Console.WriteLine("Da Merge Xong");
            TaoKhung();
        }
        public void divide()
        {
            int soHinh = 0;
            int Id;
            int idx;
            Console.WriteLine("Nhap so hinh muon devide: ");
            soHinh = int.Parse(Console.ReadLine());
            for(int i = 0; i < soHinh; i++) {
                bool flag = true;
                while(flag) {
                    Console.WriteLine("Nhap Id hinh muon devide: ");
                    Id = int.Parse(Console.ReadLine());
                    idx = this.lShape.FindIndex(x => x.Id == Id);
                    if(idx != -1) {
                        this.lShape.RemoveAt(idx);
                        flag = false;
                    }
                    else {
                        Console.WriteLine("Khong tim thay hinh!!! Xin Nhap Lai");
                    }
                }
            }
            Console.WriteLine("Da Devide Xong");
            TaoKhung();
        }
        public override void DiChuyen(Point p)
        {
            base.DiChuyen(p);
        }
        public override double DienTich()
        {
            return Math.Abs(this.p1.x - this.p2.x) * Math.Abs(this.p1.y - this.p2.y);
        }
        public override double ChuVi()
        {
            return (Math.Abs(this.p1.x - this.p2.x) + Math.Abs(this.p1.y - this.p2.y)) * 2;
        }
        public override void Ve()
        {
            Console.WriteLine("Ve MerDivObj");
        }
        public override void PhongTo()
        {
            base.PhongTo();
            TaoKhung();
        }
        public override void ThuNho()
        {
            base.ThuNho();
            TaoKhung();
        }
        public override void Menu()
        {
            base.Menu();
        }
        public void TaoKhung() {
            int x1Max = int.MinValue;
            int x2Min = int.MaxValue;
            int y1Max = int.MinValue;
            int y2Min = int.MaxValue;
            foreach(Shape s in this.lShape) {
                if(s.p1.x > x1Max)
                    x1Max = s.p1.x;
                if(s.p2.x > x1Max)
                    x1Max = s.p2.x;
                if(s.p1.y > y1Max)
                    y1Max = s.p1.y;
                if(s.p2.y > y1Max)
                    y1Max = s.p2.y;
            }
            foreach(Shape s in this.lShape) {
                if(s.p1.x < x2Min)
                    x2Min = s.p1.x;
                if(s.p2.x < x2Min)
                    x2Min = s.p2.x;
                if(s.p1.y < y2Min)
                    y2Min = s.p1.y;
                if(s.p2.y < y2Min)
                    y2Min = s.p2.y;
            }
            this.p1.x = x1Max;
            this.p1.y = y1Max;
            this.p2.x = x2Min;
            this.p2.y = y2Min;
        }
        public override void ThongTin()
        {
            base.ThongTin();
        }
    }
}