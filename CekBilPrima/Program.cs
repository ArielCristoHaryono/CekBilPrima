using System;

namespace CekBilPrima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cek Bilangan Prima");
            Console.WriteLine("masukkan input angka");
            int input = (Convert.ToInt32(Console.ReadLine()));
            if (input mod 1 == 0)
                {
                Console.WriteLine("Bilangan Prima ")
                }
            else (input mod 1!==0)
                {
                Console.WriteLine("Bukan Bilangan Prima")
                }
        }
    }
}
