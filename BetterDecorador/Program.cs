using System;

namespace BetterDecorador
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string frase = args[0];
            char c = Convert.ToChar(args[1]);
            int i = Convert.ToInt32(args[2]);
            Console.WriteLine(Decor(frase, c, i));
        }


        private static string Decor(string s, char dec, int numero)
        {
            char decorador = dec;
            string character = decorador.ToString();
            string frase = "";
            for (int i = 0; i < numero; i ++)
            {
                frase += character;
            }
            frase = frase +" "+ s + " ";
            for (int i = 0; i < numero; i ++)
            {
                frase += character;
            }
            return frase;
        }
    }
}
