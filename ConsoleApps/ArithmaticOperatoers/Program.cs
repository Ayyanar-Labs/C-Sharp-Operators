using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmaticOperatoers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add two numbers
            int iNumberOne = 15;
            int iNumberTwo = 25;
            int iAdditionResult = iNumberOne + iNumberTwo;
            Console.WriteLine("15+25=" + iAdditionResult);
            

            //Subtract two numbers
            int iSubtractResult = iNumberTwo - iNumberOne;
            Console.WriteLine("25-15=" + iSubtractResult);

            //Increment by 1
            iNumberOne++;
            Console.WriteLine("Increment by one: " + iNumberOne);

            //Decrement by 1
            iNumberTwo--;
            Console.WriteLine("Decrement by one: " + iNumberTwo);


            //Asignment Operator
            iNumberOne = 50;
            Console.WriteLine("Asign a value: " + iNumberOne);

            //Divide a number
            int iDivideResult = iNumberOne / 10;
            Console.WriteLine("Divide 50 by 10: " + iDivideResult);

            //Modulus
            int iModResult = iNumberOne % 4;
            Console.WriteLine("Remainder for (50/4)=" + iModResult);


            //Multiplication
            int iMultiplicationResult = iNumberOne * iNumberTwo;
            Console.WriteLine("50*16=" + iMultiplicationResult);




            Console.ReadLine();



        }
    }
}
