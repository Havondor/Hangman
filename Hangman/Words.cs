using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Words
    {
        private string CurrWord;
        public string HideWord;

        public Words() 
        {
            SelectWord();
        }

        private void SelectWord()
        {
            CurrWord = "hammer";
        }

        public string HiddenWord()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= CurrWord.Length; i++)
            {
                sb.Append("_ ");
            }

            sb.Remove((sb.Length - 1), 1);
            HideWord = sb.ToString();
            return sb.ToString();
        }

        public void TryLetter(char letter)
        {
            int LetterIndex = CurrWord.IndexOf(letter);

            if (LetterIndex != -1)
            {
                ShowLetter(letter);
                Console.WriteLine("{0} is a correct letter!", letter);
            }
            else
            {
                Console.WriteLine("{0} is an incorrect letter!", letter);
            }
            
        }

        private void ShowLetter(char letter)
        {
            StringBuilder sb = new StringBuilder();
            string ShrunkHideWord = HideWord.Replace(" ", "");

            for (int i = 0; i < CurrWord.Length; i++)
            {
                char c = CurrWord[i];
                char s = ShrunkHideWord[i];

                if (c == letter)
                {
                    sb.Append(c);
                }
                else
                {
                    sb.Append(s);
                }

            }
            
            StringBuilder sb2 = new StringBuilder();

            foreach (char c in sb.ToString())
            {
                sb2.Append(c).Append(" ");
            }

            HideWord = sb2.ToString().TrimEnd();
        }

    }
}
