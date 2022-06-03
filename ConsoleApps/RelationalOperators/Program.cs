using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //==
            int iNumberA = 15;
            int iNumberB = 20;


            //Check two values are equal
            if (iNumberA == 100)
            {
                Console.WriteLine("iNumberA is 100");

            }
            else
            {

                Console.WriteLine("iNumberA is not 100");
            }

            //Check two values are equal
            if (iNumberA != 100)
            {
                Console.WriteLine("iNumberA is not 100");

            }
            else
            {

                Console.WriteLine("iNumberA is  100");
            }



            //Less than
            if (iNumberA < 100)
            {
                Console.WriteLine("iNumberA is less than 100");

            }
            else
            {

                Console.WriteLine("iNumberA is not less than 100");
            }


            //Greater than
            if (iNumberA > 100)
            {
                Console.WriteLine("iNumberA is greater 100");

            }
            else
            {

                Console.WriteLine("iNumberA is not greater than 100");
            }


            //Less than ot Equal
            if (iNumberA <= 100)
            {
                Console.WriteLine("iNumberA is less than or equal to 100");

            }
            else
            {

                Console.WriteLine("iNumberA is not less than or equal to 100");
            }

            //Less than ot Equal
            if (iNumberA >= 100)
            {
                Console.WriteLine("iNumberA is greater than or equal to 100");

            }
            else
            {

                Console.WriteLine("iNumberA is not greater than or equal to 100");
            }







            Console.ReadLine();
        }
    }
}
