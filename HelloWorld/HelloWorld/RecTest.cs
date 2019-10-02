using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class RecTest
    {
        static void Main(String[] args)
        {
            Rectangle1 r = new Rectangle1();
            r.height = 4;
            r.width = 5;
            Console.WriteLine("Area of the Recctangle is"    +(r.height * r.width));

        }


        }
}
