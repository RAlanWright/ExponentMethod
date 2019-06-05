using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExponentMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetPow(8, -1));


            Console.ReadLine();
        }

        static double GetPow(int baseNum, int powNum)
        {
            double result = 1;
            
            if (powNum > 0)
            {
                for (int i = 0; i < powNum; i++)
                {
                    result = result * baseNum;
                }
            } else if (powNum < 0)
            {
                for (int i = 0; i > powNum; i--)
                {
                    result = result / baseNum;
                }
            }
            

            return result;
        }

    }
}
