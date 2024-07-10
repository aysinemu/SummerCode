using System;
using System.IO.Compression;

namespace SummerCode
{
    class SummerCode
    {   
        static double add(double a, double b){
            Console.Write("Dap An:");
            return a + b;
        }
        static double sub(double a, double b){
            Console.Write("Dap An:");
            return a - b;
        }
        static double mult(double a, double b){
            Console.Write("Dap An:");
            return a * b;
        }
        static double div(double a, double b){
            Console.Write("Dap An:");
            return a / b;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap 1: add , 2: sub , 3: mult , 4: div :");
            int c = Convert.ToInt32(Console.ReadLine());
            if (c == 1){
                Console.Write(add(a,b));
            }else if (c == 2){
                Console.Write(sub(a,b));
            }else if (c == 3){
                Console.Write(mult(a,b));
            }else if (c == 4){
                Console.Write(div(a,b));
            }
        }
    }
}