using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_NgoThiThuyLinh_Buoi3_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bai 3
            //TamGiac TamGiac1 = new TamGiac(3, 4, 5);
            //TamGiac TamGiac2 = new TamGiac(8, 8, 5);
            //TamGiac TamGiac3 = new TamGiac(4, 4, 4);
            //TamGiac TamGiac4 = new TamGiac(5,3 ,6 );
            //TamGiac TamGiac5 = new TamGiac(5, 5, 5);
            //Console.WriteLine("Thong so Tam Giac");
            //Console.WriteLine("ma\tmb\tmc\tLoai Tam Giac\tChu Vi\tDien Tich");
            //Console.WriteLine("==============================================");
            //Console.WriteLine(TamGiac1.Xuat());
            //Console.WriteLine(TamGiac2.Xuat());
            //Console.WriteLine(TamGiac3.Xuat());
            //Console.WriteLine(TamGiac4.Xuat());
            //Console.WriteLine(TamGiac5.Xuat());
            //Bai 4
            Vehicle xe1 = new Vehicle("NgoThiThuyLinh", "Roll-Royce", 10651252500, 6000);
            Vehicle xe2 = new Vehicle("Vu Minh Chien", "Lamborghini", 26000000000, 6498);
            Vehicle xe3 = new Vehicle("Ngo Ai Linh", "Ferrari  ", 20000000000, 5300);
            Vehicle xe4 = new Vehicle("VuThiMinhTam", "Mercedes", 10000000000, 5300);
            Console.WriteLine("Chu Xe\tLoai Xe\t\tTri Gia\t\t\tDung Tich\tThue Tri Gia");
            Console.WriteLine("========================================================");
            Console.WriteLine(xe1.Xuat());
            Console.WriteLine(xe2.Xuat());
            Console.WriteLine(xe3.Xuat());
            Console.WriteLine(xe4.Xuat());
            Console.ReadLine();
        }
    }
}
