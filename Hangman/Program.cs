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
            

            //int x = 0;

            while (1 == 1)
            {
                Console.WriteLine("The Current Word is {0}", wd.HideWord);
                Console.WriteLine("Enter a letter to try: ");
                string Input = Console.ReadLine().ToLower();
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
                    
                }

                //x += 1;
                //if (x == 2) 
                //{
                //    break;
                //}
            }
            

        }
    }
}
