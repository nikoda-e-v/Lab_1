using System;

namespace unitTests_1
{
   public class Program
    {


        public static int getNumber(int n)
        {
            int MaxZeroes = 0;
            int num = 0;
            for (int i = 1; i < n; i++)
            {
                int zeroes = 0;
                string number = Convert.ToString(i, 2);
                for (int j = 0; j < number.Length; j++)
                {
                    if (number[j].Equals("0"))
                    {
                        zeroes++;

                    }
                    if (zeroes > MaxZeroes)
                    {
                        MaxZeroes = zeroes;
                        num = i;
                    }
                }
            }
            return num;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа № ");
        }
    }
}
