using System;

namespace HarmonicProgram
{
    public class program
    {
        public static void main(string[] args)
        {
            Console.WriteLine("Welcome To The Harmonic Number:");
            bool end = true;
            Console.WriteLine("1. Harmonic Number\n");
            while (end == true)
            {
                Console.WriteLine("Choose Harmonic:");
                int option = Convert.ToInt32(Console.ReadLine();
                switch (option)
                {
                    case 1:
                        Harmonic num = new Harmonic();
                        num.Number();
                        break;
                    default:
                        Console.WriteLine("Choose Correct Number");
                        break;
                }
            }
        }
    }
}