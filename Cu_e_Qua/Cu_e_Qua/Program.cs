using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cu_e_Qua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine());
            int result = 0;

            for (int aux_cont = num1; aux_cont <= num2; aux_cont++)
            {
                if (Math.Sqrt(aux_cont) % 1 == 0)
                {
                    for (int aux_cu = 1; aux_cu < aux_cont; aux_cu++)
                    {
                        if (Math.Pow(aux_cu, 3.0) == aux_cont)
                        {
                            result++;
                            Console.WriteLine(aux_cont);
                        }
                    }
                }
                //Console.WriteLine(aux_cont);
            }

            Console.WriteLine("----");
            Console.WriteLine(result);

        }
    }
}

