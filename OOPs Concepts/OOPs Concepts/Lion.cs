using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{
    class Lion : Animal
    {

        public void sleep()
        {
            Console.WriteLine("sleeping...");
        }
        public  override void eat()
        {
            Console.WriteLine("in Lion Eating...");
        }
    }
    }

