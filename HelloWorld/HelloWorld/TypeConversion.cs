using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class TypeConversion
    {
        static void Main(String[] args) { 
                double d = 89.56;
          int i;

        // cast double to int.
           i = (int)d;
            Console.WriteLine(d);
            Console.WriteLine(i);
            //implicit conversion
            int i1 = 348758909;
            Int32 i2 = i1;
            Console.WriteLine(i2);
            //Explict Conversion (the values may change)
            double d1= 123.45;
            int i3;
            // Cast double to int.
            i3 = (int)d1;

            Console.WriteLine(i3);




        }

    }
}