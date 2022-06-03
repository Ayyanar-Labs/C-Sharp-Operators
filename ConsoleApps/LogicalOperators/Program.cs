using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //AND Operator
            
            bool isCloud = true;
            bool isCoolClimate = true;

            Console.WriteLine("AND Operator: ");
            if (isCloud && isCoolClimate)
            {
                Console.Write("Please take an umbrella.");
            }
            else
            {
                Console.WriteLine("No need for umbrella.");
            }

            Console.WriteLine("OR Operator: ");

            //OR Operator
            isCloud = false;
            isCoolClimate = false;

            if (isCloud || isCoolClimate)
            {
                Console.Write("Please take an umbrella.");
            }
            else
            {
                Console.WriteLine("No need for umbrella.");
            }

            Console.WriteLine("NOT Operator: ");

            //OR Operator
            isCloud = false;
            isCoolClimate = false;

            if (!isCloud)
            {
                Console.Write("Please take an umbrella.");
            }
            else
            {
                Console.WriteLine("No need for umbrella.");
            }

            Console.ReadLine();
        }
    }
}
