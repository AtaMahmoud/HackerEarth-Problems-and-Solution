using System;
using System.Linq;

 class Program
    {
        static void Main(string[] args)
        {
         char[] vowels = new char[] { 'a', 'e', 'o', 'u', 'i' };
            Console.Write("Enter an English word : ");
            String word = Console.ReadLine().ToLower();
            int vowelsCounter = 0;
           foreach(var character in word)
            {
                if (vowels.Contains(character))
                    vowelsCounter++;
            }
            Console.WriteLine(vowelsCounter);
        }
     } 
