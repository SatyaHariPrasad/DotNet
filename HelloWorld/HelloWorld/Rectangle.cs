using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Rectangle
    {
        //declare variables
        double length;
        double width;
  
    //creating a method to intialize variables
    public void IntializeVar()
    {
        length = 2.6;
        width = 4.7;
    }
    public double GetArea()
    {
        return length * width;
    }
    public void Display()
    {
        Console.WriteLine("Length: {0}", length);
        Console.WriteLine("Width: {0}", width);
        Console.WriteLine("Area: {0}", GetArea());
    }
}
}