
namespace ReversingAStringExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Please enter the word that you want to reverse;");
            string inputUser = Console.ReadLine();


            string reverse = "";
            for (int i = inputUser.Length - 1; i >= 0; i--)
            {
                reverse += inputUser[i];
                Console.WriteLine(reverse);
            }

            bool palindrome = true;
            for (int i = 0; i < inputUser.Length; i++)
            {
                if (inputUser != reverse)
                {
                    palindrome = false;
                    break;
                }
            }

            if (palindrome)
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
