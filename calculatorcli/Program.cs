using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi  Calculator Versi Console";

            Console.Write("inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("inputkan nilai b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan: {0} - {1} = {2}", a, b, pengurangan(a, b));
            Console.WriteLine("Hasil perkalian: {0} x {1} = {2}", a, b, perkalian(a, b));
            Console.WriteLine("Hasil pembagian: {0} / {1} = {2}", a, b, pembagian(a, b));

            Console.ReadKey();
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
    }
}
