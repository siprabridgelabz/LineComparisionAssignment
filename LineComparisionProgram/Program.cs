using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Line Comaprision Problem");
            LineComparision lineComparision = new LineComparision();
            lineComparision.DisplayResult();
            Console.ReadLine();
        }
    }
}
