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
            // for calculate length for first two lines
            Console.WriteLine("Enter the value of x-cordinate of point1: x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y-cordinate of point1: y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x-cordinate of point2: x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y-cordinate of point1: y2");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double firstLengthOfLine = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            Console.WriteLine("Distance between two line " + "(" + x1 + ", " + y1 + ")" + "(" + x2 + ", " + y2 + ") is: " + firstLengthOfLine);


            // for calculate length for second two lines

            Console.WriteLine("Enter the value of x-cordinate of point3: x3");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y-cordinate of point3: y3");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x-cordinate of point4: x4");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y-cordinate of point4: y4");
            int y4 = Convert.ToInt32(Console.ReadLine());

            double SecondLengthOfLine = Math.Sqrt(((x4 - x3) * (x4 - x3)) + ((y4 - y3) * (y4 - y3)));
            Console.WriteLine("Distance between two line " + "(" + x3 + ", " + y3 + ")" + "(" + x4 + ", " + y4 + ") is: " + SecondLengthOfLine);


            // Compare the lengths
            if (firstLengthOfLine == SecondLengthOfLine)
            {
                Console.WriteLine("The firstLengthOfLine and SecondLengthOfLine are equal");
            }
            else
            {
                Console.WriteLine("The firstLengthOfLine and SecondLengthOfLine are notequal");
                if (firstLengthOfLine > SecondLengthOfLine)
                {
                    Console.WriteLine("The firstLengthOfLine is greater than SecondLengthOfLine");
                }
                else
                {
                    Console.WriteLine("The SecondLengthOfLine is greater than firstLengthOfLine");
                }
            }
        }
    }
}
