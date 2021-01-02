using System;
using System.Collections.Generic;

namespace Polymorphism
{
    public static class GroupComplex {
        private static List<ComplexObj> lComp = new List<ComplexObj>();
        public static List<ComplexObj> Comp
        {
            get { return GroupComplex.lComp; }
            set { GroupComplex.Comp = value; }
        }
        static GroupComplex(){

        }
        public static void Xuat()
        {
            for(int i = 0; i < lComp.Count; i++) {
                Console.WriteLine($"-----------------------------COMPLEX {i}------------------------------------");
                lComp[i].Xuat();
            }
        }
        public static void Menu() {
            int chon;
            do {
                Console.WriteLine("\t\t\t |============================GROUP COMPLEX============================|\n");
                Console.WriteLine("\t\t\t |================================MENU=================================|\n");
                Console.WriteLine("\t\t\t |                            1. Merge                                 |\n");
                Console.WriteLine("\t\t\t |                            2. Divide                                |\n");
                Console.WriteLine("\t\t\t |                            3. Danh Sach ComplexObj                  |\n");
                Console.WriteLine("\t\t\t |                            4. Danh Sach MerDivObj                   |\n");
                Console.WriteLine("\t\t\t |                            5. Thao tac voi ComplexObj               |\n");
                Console.WriteLine("\t\t\t |                            6. Thao tac voi MerDivObj                |\n");
                Console.WriteLine("\t\t\t |                            7. Quay Lai                              |\n");
                Console.WriteLine("\t\t\t |                            8. Thoat                                 |\n");
                Console.WriteLine("\t\t\t |===============================CHOOSE================================|\n");
                Console.Write("Ban chon: ");
                chon = int.Parse(Console.ReadLine());
                switch(chon) {
                    case 1:
                            Console.Clear();
                            int idx;
                            Console.WriteLine("Chon ComplexObj su dung de merge: ");
                            idx = int.Parse(Console.ReadLine());
                            if(idx >= 0 && idx < GroupComplex.Comp.Count) {
                                Graphic g = new Graphic();
                                g.merge(GroupComplex.Comp[idx]);
                                GroupMerDiv.Gra.Add(g);
                            }
                            else {
                                Console.WriteLine("Khong the lay ComplexObj de merge");
                            }
                            break;
                    case 2:
                            Console.Clear();
                            Console.WriteLine("Chon danh sach da merged/devided de devide: ");
                            idx = int.Parse(Console.ReadLine());
                            if(idx >= 0 && idx < GroupMerDiv.Gra.Count) {
                                GroupMerDiv.Gra[idx].divide();
                            }
                            else {
                                Console.WriteLine("Khong the lay ComplexObj de merge");
                            }
                            break;
                    case 3:
                            Console.Clear();
                            Xuat();
                            break;
                    case 4:
                            Console.Clear();
                            if(GroupMerDiv.Gra.Count == 0)
                                break;
                                for(int i = 0; i < GroupMerDiv.Gra.Count; i++) {
                                    Console.WriteLine($"------------------------COMPLEX MERGED/DIVIDED {i}--------------------------");
                                    GroupMerDiv.Gra[i].Xuat();
                                }
                            break;
                    case 5:
                            Console.Clear();
                            Console.WriteLine("Chon ComplexObj: ");
                            idx = int.Parse(Console.ReadLine());
                            if(idx >= 0 && idx < GroupComplex.Comp.Count) {
                                GroupComplex.Comp[idx].Menu();
                            }
                            else {
                                Console.WriteLine("Khong tim thay ComplexObj");
                            }
                            break;
                    case 6:
                            Console.Clear();
                            Console.WriteLine("Chon MerDivObj: ");
                            idx = int.Parse(Console.ReadLine());
                            if(idx >= 0 && idx < GroupMerDiv.Gra.Count) {
                                GroupMerDiv.Gra[idx].Menu();
                            }
                            else {
                                Console.WriteLine("Khong tim thay MerDivObj");
                            }
                            break;
                    case 7:
                            Console.Clear();
                            Program.Main(null);
                            break;
                    case 8:
                            Environment.Exit(0);
                            break;
                    default:
                            Console.Clear();
                            break;
                }
            }
            while(chon != 7 || chon != 8);
        }
    }
}