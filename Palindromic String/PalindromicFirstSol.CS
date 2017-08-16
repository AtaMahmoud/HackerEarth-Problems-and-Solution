using System;

namespace Palindromic_String
{
    class Program
    {
        static void Main(string[] args)
        {
             int flag = 0;
             char[] word = Console.ReadLine().ToCharArray();
             word.ToString().ToLower();
             int k = word.Length-1;

             char[] reversedWord = new char[word.Length];

             for (int i = 0 ; i<word.Length ; i++)
             {
                 if (k == -1)
                     break;

                 reversedWord[i] = word[k];
                     k--;

             }
             for (int i = 0; i < word.Length; i++)
             {
                 if (reversedWord[i]==word[i])
                 {
                     flag = 0;
                 }
                 else
                 {
                     flag = 1;
                 }
             }
             if (flag == 1)
             {
                 Console.WriteLine("No");
             }
             else
             {
                 Console.WriteLine("YES");
             }
            

        }
    }
}
