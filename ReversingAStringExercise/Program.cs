
namespace ReversingAStringExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the word that you want to reverse: ");
            string inputUser = Console.ReadLine().ToLower();

            char[] reverse = new char[inputUser.Length];
            int counter = inputUser.Length - 1;

            for (int i = 0; i < inputUser.Length; i++)
            {
                reverse[counter] = inputUser[i];
                counter--;
            }
         
            
            bool palindrome = true;

            for (int i = 0; i < inputUser.Length; i++)
            {         
                if (inputUser[i] != reverse[i])
                {
                    palindrome = false;
                }
            }
                     
            
            if (palindrome)
                      
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a Palindrome");
            }
        }
    }
}
