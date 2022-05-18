using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonicProgram
{
    public class Harmonic
    {
        public void Number()
        {
            int num = 0;
            double Result = 0.0;
            Console.Write("Input Your Number: ");

            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Result += 1 / (float)i;
                Console.Write("1/{0} + ", 1);
            }
            Console.WriteLine($"= {Result}");
            Console.ReadLine();
        }
    }
}
