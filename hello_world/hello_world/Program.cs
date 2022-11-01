using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace hello_world
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float milisec = 2000.0f;
            int milisec_int = Convert.ToInt32(milisec);

            Console.WriteLine("hello world {0}", milisec);

            Thread.Sleep(milisec_int);
        }
    }
}
