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
                Console.WriteLine($"{"", 25}-----------------------------COMPLEX {i}---------------------------------");
                lComp[i].ThongTin();
            }
        }
        public static void Menu() {
            int chon;
            try {
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
                                    MergeObj g = new MergeObj();
                                    g.merge(GroupComplex.Comp[idx]);
                                    GroupMerge.Mer.Add(g);
                                }
                                else {
                                    Console.WriteLine("Khong the lay ComplexObj de merge");
                                }
                                break;
                        case 2:
                                Console.Clear();
                                Console.WriteLine("Chon danh sach da merged/devided de devide: ");
                                idx = int.Parse(Console.ReadLine());
                                if(idx >= 0 && idx < GroupMerge.Mer.Count) {
                                    GroupMerge.Mer[idx].divide();
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
                                if(GroupMerge.Mer.Count == 0)
                                    break;
                                    for(int i = 0; i < GroupMerge.Mer.Count; i++) {
                                        Console.WriteLine($"{"", 25}------------------------COMPLEX MERGED/DIVIDED {i}--------------------------");
                                        GroupMerge.Mer[i].ThongTin();
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
                                if(idx >= 0 && idx < GroupMerge.Mer.Count) {
                                    GroupMerge.Mer[idx].Menu();
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
                                Console.WriteLine("Vui Long Nhap Lai");
                                break;
                    }
                }
                while(chon != 7 || chon != 8);
            }
            catch(System.FormatException) {
                Console.Clear();
                Console.WriteLine("Vui Long Nhap Chu So");
                GroupComplex.Menu();
            }
        }
    }
}