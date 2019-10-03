using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{
    class StringPgm
    {
        class StringProg
        {

            static void Main(string[] args)
            {
                string str1 = "hello";
                string str2 = "hello1";
                
                if (str1.Equals(str2))
                {
                    Console.WriteLine(str1 + " and " + str2 + " are equal.");
                }
                else
                {
                    Console.WriteLine(str1 + " and " + str2 + " are not equal.");
                }
                Console.ReadKey();
            }
        }
    }
}

