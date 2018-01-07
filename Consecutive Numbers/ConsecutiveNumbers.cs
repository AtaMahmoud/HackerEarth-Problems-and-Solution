using System;

 class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Numbers Spereated by Hypen :- ");
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split('-'), Int32.Parse);
            bool isConsecutive= true;
            Array.Sort(numbers);
            for (int i = 1; i < numbers.Length; i++)
            {
                if (i == numbers.Length)
                    break;

                if (numbers[i] != numbers[i - 1] + 1)
                    isConsecutive = false;
                   
                
            }
            
           if(isConsecutive)
                Console.WriteLine("Consecutive");
           else
                Console.WriteLine("Not Consecutive");
            
        }
    }
