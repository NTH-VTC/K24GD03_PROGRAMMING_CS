using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");
            TinhThuong(10,2);
            Console.ReadLine();
        }
        double TinhThuong(double a, double b) {
            return a / b;
        }
    }
}
