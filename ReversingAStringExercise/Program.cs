using System.Text.RegularExpressions;

namespace ReversingAStringExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word: ");
            string userWord = Console.ReadLine();

            Regex regex = new Regex(@"^[a-zA-Z]+$");

            if (userWord.Equals(regex)!)
            {
                Console.WriteLine("Please enter a valid word: ");
            }
            else
            {
                char[] chars = userWord.ToCharArray();
                char[] charsReversed = new char[chars.Length];


                for (int i = chars.Length - 1; i >= 0; i--)
                {
                    charsReversed[i] = chars[i];
                    Console.Write(charsReversed[i]);
                }

                for (int i = chars.Length - 1; i >= 0; i--)
                {

                    for (int j = 0; j < chars.Length; j++)
                    {
                        

                    }

                }

            }

            Console.WriteLine("This is the end");
            var whatever = Console.ReadLine;
        }
    }
}