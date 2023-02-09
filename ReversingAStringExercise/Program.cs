using System.Text.RegularExpressions;

namespace ReversingAStringExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter a word that you want to be reversed: ");
            //string userWord = Console.ReadLine();

            //Regex regex = new Regex(@"^[a-zA-Z]+$");


            //char[] chars = userWord.ToCharArray();
            //char[] charsReversed = new char[chars.Length];
            //int counter = 2;
            //int j;


            //for (int i = chars.Length - 1; i >= 0; i--)
            //{
            //    for (j = 1; j < counter; j++)
            //    {
            //        charsReversed[i] = chars[i];
            //        Console.Write(charsReversed[i]);
            //    }
            //    j++;
            //    counter++;
            //}


            //if (chars == charsReversed)
            //{
            //    Console.WriteLine("This word is a palindrome");
            //}
            //else
            //{
            //    Console.WriteLine("This word is not a palindrome");
            //}

            Console.WriteLine("Please enter the word that you want to reverse;");
            string inputUser = Console.ReadLine();
            

            string reverse = "";
            for(int i = inputUser.Length - 1; 1 >= 0; i--)
            {
                reverse += inputUser[i]; // Error is here . An excetption is being throw : SystemIindexOutOfRangeException
                Console.WriteLine(reverse);

            }

            bool palindrome = true;
            for (int i = 0; i < inputUser.Length; i++) {
                if (inputUser[i] != reverse[i])
                {
                    palindrome = false;
                }
            }

            if(palindrome) // This condition is not beign processed at all. According to the 2nd for loop --->
                           //-->  palindrome bool is either set to false or true and should print either statement
            {
                Console.WriteLine("PALINDROME");
            }
            else
            {
                Console.WriteLine("NOT A PALINDROME");
            }
        }

    }
}