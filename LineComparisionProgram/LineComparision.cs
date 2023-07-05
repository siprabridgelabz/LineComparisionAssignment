using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProgram
{
    public class LineComparision
    {
        public void DisplayResult()
        {
            Console.WriteLine("Enter the value of x-cordinate of point1: x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y-cordinate of point1: y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x-cordinate of point2: x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y-cordinate of point1: y2");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double line_Length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of the line is : " + line_Length);
        }
    }
}
