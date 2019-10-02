using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class VariablesIntial
    {
        static void Main(String[] args)
        {
            byte a;
            int b;
            double c;
            //intializing the Variables
            a = 10;
            b = 25;
            c = a + b;
            Console.WriteLine(c);
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sample");
        }
    }
}
