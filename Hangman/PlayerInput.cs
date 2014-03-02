using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hangman
{        
    public class PlayerInput
    {
        public bool running;
        private Regex rgx = new Regex(@"[^a-zA-z]");
        private Words wd = new Words();

        public PlayerInput()
        {            
            running = true;
            wd.NewWord();
        }

        private void CheckInput(string Input)
        {
            if (rgx.IsMatch(Input))
            {
                Console.WriteLine("Please Enter a Valid Letter Only");
            }
            else if (Input.Length > 1)
            {
                Console.WriteLine("Please only Enter one letter at a time");
            }
            else
            {
                char c = Input[0];
                wd.TryLetter(c);
            }
        }

        public void GetInput()
        {
            Console.WriteLine("The Current Word is {0}", wd.HideWord);
            Console.WriteLine("Enter a letter to try: ");

            string Input = Console.ReadLine();

            CheckInput(Input);
        }

        
    }
}
