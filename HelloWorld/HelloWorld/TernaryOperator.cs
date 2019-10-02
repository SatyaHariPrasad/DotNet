using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class TernaryOperator
    {
        static void Main(String[] args)
        {

            int number = 2;
            bool isEven;
            isEven = (number % 2 == 0) ? true : false;
            Console.WriteLine(isEven);
        }
    }
}
