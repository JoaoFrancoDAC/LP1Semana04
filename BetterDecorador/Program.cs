using System;

namespace BetterDecorador
{
    public class Program
    {
        /// <summary>
        /// Main program that receive the needed args to call the method Decor
        /// </summary>
        /// <param name="args"> Argumentos necessários, sendo necessariamente uma string, seguido de um character e um número</param>
        private static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine(Decor());
            }
            else 
            {
                string frase = args[0];
                char c = Convert.ToChar(args[1]);
                int i = Convert.ToInt32(args[2]);
                Console.WriteLine(Decor(frase, c, i));
            }
        }


        /// <summary>
        /// Method to write a string with the specified decoration around it's main text line.
        /// </summary>
        /// <param name="s"> String that gonna be in the middle</param>
        /// <param name="dec">character used to decorate the start and end of the string</param>
        /// <param name="numero">number of times that the character shows up</param>
        /// <returns></returns>
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
        /// <summary>
        /// Overload of the method Decor in case the user doesn't specify the right amount of arguments
        /// </summary>
        /// <returns></returns>
        private static string Decor()
        {
            return "=== User did not specify args! ===";
        }
    }
}
