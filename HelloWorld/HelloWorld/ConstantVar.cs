using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class ConstantVar
    {
        public static void Main(String[] args)
        {
            const double pi = 3.141;
            double r;
            Console.WriteLine("Enter the Radius:");
            r = Convert.ToDouble(Console.ReadLine());
            double areaofcircle = pi * r * r;
            Console.WriteLine(areaofcircle);
            Console.WriteLine("Radius: {0}, Area: {1}", r, areaofcircle);
            //Console.ReadLine();
        }
    }

}
