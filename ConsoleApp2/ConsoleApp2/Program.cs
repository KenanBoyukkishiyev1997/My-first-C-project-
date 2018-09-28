using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("eded daxil edin");
            int s;
            bool parsed = int.TryParse(Console.ReadLine(), out s);
            if (parsed)
            {
                s++;
                Console.WriteLine("daxil etdiyiniz eded budu :" + s);
            }
            else
            {
                Console.WriteLine("daxil etdiyiniz ededin  :" );
            }
          
               
            

        }
    }
}
