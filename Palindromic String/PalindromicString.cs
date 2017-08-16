using System;

namespace Palindromic_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string reversedWord =null;
            word.ToCharArray();
            for (int i = word.Length-1; i >=0; i--)
            {
                reversedWord += word[i];
            }
            
            if(word.Equals(reversedWord))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
