using System;
using System.IO.Compression;

namespace SummerCode
{
    class SummerCode
    {   
        static double sub(double a, double b){
            Console.Write("Dap An:");
            return a - b;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write(sub(a,b));
        }
    }
}