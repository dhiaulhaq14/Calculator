using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CalculatorApp
{
    class Calculator
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("[1] Penambahan");
            Console.WriteLine("[2] Pengurangan");
            Console.WriteLine("[3] Perkalian");
            Console.WriteLine("[4] Pembagian");
            Console.WriteLine("[5] Sisa bagi");
            Console.WriteLine("Pilih Operasi lalu tekan ENTER");
            int pilihan = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukkan Angka Pertama : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukkan Angka Kedua : ");
            int b = Convert.ToInt32(Console.ReadLine());
            int hasil = 0;

            switch (pilihan)
            {
                case 1:
                    {
                        hasil = Penambahan(a, b);
                        break;
                    }
                case 2:
                    {
                        hasil = Pengurangan(a, b);
                        break;
                    }
                case 3:
                    {
                        hasil = Perkalian(a, b);
                        break;
                    }
                case 4:
                    {
                        hasil = Pembagian(a, b);
                        break;
                    }
                case 5:
                    {
                        hasil = hasilBagi(a, b);
                        break;
                    }
                default:
                    Console.WriteLine("Masukkan Pilihan Operasi dengan benar !");
                    break;
            }
            Console.WriteLine("Hasil {0}", hasil);
            if () ;
            {

            }
            Console.ReadKey();
        }
        static int Penambahan(int a, int b)
        {
            int hasil = a + b;
            return hasil;
        }
        static int Pengurangan(int a, int b)
        {
            int hasil = a - b;
            return hasil;
        }
        static int Perkalian(int a, int b)
        {
            int hasil = a * b;
            return hasil;
        }
        static int Pembagian(int a, int b)
        {
            int hasil = a / b;
            return hasil;
        }
        static int hasilBagi(int a, int b)
        {
            int hasil = a % b;
            return hasil;
        }
    }
}