using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorsNumber
{
    public class FactorsNumberProgram
    {
        int factorial;
        public void FactorsWithoutRecursion()
        {
            int Fact = 1;
            Console.WriteLine("Enter The Number: ");
            int Num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= Num; i++)
            {
                Fact = Fact * i;
            }
            Console.WriteLine("Factorial Number Is: " + Fact);
        }
        public int Factorial(int num)
        {
            //Console.WriteLine("Enter The Number: ");
            //int Num = Convert.ToInt32(Console.ReadLine());
            factorial =Factorial(num);
            if (num == 0)
            {
                return 1;
            }
            else
            {
                return num * Factorial(num - 1);
            }
        }

    }      
    
}
    
