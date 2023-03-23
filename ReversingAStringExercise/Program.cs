
namespace ReversingAStringExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the word that you want to reverse: ");
            string inputUser = Console.ReadLine().ToLower();

            string reverse = "";
            
            for (int i = 1; i <= inputUser.Length; i++)
            {
                reverse += inputUser[inputUser.Length - i];
            }
                
            bool palindrome = true;

            for (int i = 0; i < inputUser.Length -1; i++)
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
