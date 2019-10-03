using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{
    class EncapusalationTest
    {
        static void Main(String[] args)
        {
            Student s = new Student();
            //setting the values
            s.ID = 101;
            s.Name= "satya";
            s.Email = "satya@gmail.com";
            //getting the vallues by getter methods
            Console.WriteLine("Id=="+s.ID);
            Console.WriteLine("Name==" + s.Name);
            Console.WriteLine("Email==" + s.Email);



        }
    }
}
