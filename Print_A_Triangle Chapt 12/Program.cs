using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_A_Triangle_Chapt_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 5;
            for(int i =0; i < rows; i ++)
            {
                for (int k = rows - i - 1; k >= 0; k--)
                    Console.Write(" ");

                for (int j = 0; j <=i; j++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine(" ");
            }
        }
    }
}
