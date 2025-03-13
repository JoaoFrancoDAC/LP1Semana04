using System;
using System.Runtime.InteropServices;

namespace Special
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insert n-th number of the special sequence: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetSpecial(n));
        }

        private static int GetSpecial(int n)
        {
            int soma;
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else 
            {
                soma = GetSpecial(n-1) + 2 * GetSpecial(n-2);
                return soma;
            }
        }
    }
}
