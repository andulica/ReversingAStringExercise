﻿
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

            if (inputUser != reverse)         
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
