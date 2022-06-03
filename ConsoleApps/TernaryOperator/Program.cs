using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int iCount = 0;

            //if (iCount == 0)
            //{
            //    Console.WriteLine("The given number is zero.");
            //}
            //else
            //{
            //    Console.WriteLine("The given number is not zero");
            //}


            //if (iCount == 0) Console.WriteLine("The given number is zero.");
            //Console.WriteLine("The given number is not zero");


            string Message = (iCount == 0) ? "The given number is zero." : "The given number is not zero";

            Console.WriteLine(Message);





            Console.ReadLine();
        }
    }
}
