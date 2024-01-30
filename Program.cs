using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int mcm;
            int mcd;
            Console.WriteLine("primo numero = ");
            num1 = int.Parse(Console.ReadLine());
                  Console.WriteLine("secondo numero = ");
                num2 = int.Parse(Console.ReadLine());
            
            while(num1 != num2)
            {
                if(num1 > num2)
                {
                    num1 = num1 - num2;
                }
                else
                {
                    num2 = num2 - num1;
                }
                
               
            }
            mcm = num1;
            mcd = (num1 * num2) / mcm; 

            Console.WriteLine("il mcd è {0}", mcd);
            Console.ReadLine();
        }

    }
}
