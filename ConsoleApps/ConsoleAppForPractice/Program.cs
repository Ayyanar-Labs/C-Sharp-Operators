using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int iCount = 23;
            int cCount = 40;
            bool bValue = false;





            if (cCount > iCount)
            {
                bValue = true;
            }


            if (bValue == true)
            {
                Console.WriteLine("cCount is bigger than icount");
            }
            else
            {
                Console.WriteLine("iCount is bigger than ccount");
            }
            Console.ReadLine();
        }
    }
}
