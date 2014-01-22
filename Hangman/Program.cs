using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Words wd = new Words();
            Console.WriteLine("The Current Word is {0}", wd.HiddenWord());
            Console.WriteLine("Enter a letter to try: ");

            int x = 0;

            while (1 == 1)
            {
                string Input = Console.ReadLine();
                int Num;
                if (string.IsNullOrEmpty(Input) || int.TryParse(Input, out Num))
                {
                    Console.WriteLine("Please Enter a Valid Letter Only");
                }
                else if (Input.Length > 1)
                {
                    Console.WriteLine("Please only Enter on letter at a time");
                }
                else
                {
                    char c = Input[0];
                    wd.TryLetter(c);
                    Console.WriteLine();
                    Console.WriteLine("The Current Word is {0}", wd.HideWord);
                    Console.WriteLine();
                    Console.WriteLine("Enter a letter to try: ");
                }

                x += 1;
                if (x == 2) 
                {
                    break;
                }
            }
            

        }
    }
}
