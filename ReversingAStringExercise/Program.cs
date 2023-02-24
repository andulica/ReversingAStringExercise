
namespace ReversingAStringExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please enter the word that you want to reverse: ");
            string inputUser = Console.ReadLine().ToLower();



            //string reverse = "";
            //for (int i = 0; i < inputUser.Length; i++)
            //{
            //    reverse += inputUser[i];
            //    Console.WriteLine(reverse);
            //    i--;
            //    if (inputUser[i] == reverse[i])
            //    continue;
            //}

            //bool palindrome = true;
            //for (int i = 0; i < inputUser.Length; i++)
            //{
            //    if (inputUser != reverse)
            //    {
            //        palindrome = false;
            //        break;
            //    }
            //}

            //if (palindrome)
            //{
            //    Console.WriteLine("PALINDROME");
            //}
            //else
            //{
            //    Console.WriteLine("NOT A PALINDROME");
            //}


            // banana
            // make an char array emty which will contain the reversed word of user input

            // for loop to iterate the user input by each char and store it in the char array
            // after each storage we need to move the just introduced element a position higher by creating and empty space '' 
            // on the previous place that he was in

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
                Console.WriteLine("no Palindrome");
            }
        }

    }
}
