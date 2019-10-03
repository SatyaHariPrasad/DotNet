using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{
    class TestAggregationInherit
    {
        static void Main (String[] args)
        {
            Address a = new Address("hyb", "sompeta","gdjkd");
            Employee e = new Employee(1,"satay",a);
            e.display();
        }
    }
}
