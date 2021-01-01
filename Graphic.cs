using System;
using System.Collections.Generic;

namespace Polymorphism
{
    public class Graphic: ComplexObj
    {
        public Graphic(): base()
        {
        }
        ~Graphic()
        {
        }
        public Graphic(List<Shape> lShape)
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
        }
        public override void TaoKhung()
        {
            base.TaoKhung();
        }
        public override void Xuat()
        {
            base.Xuat();
        }
    }
}