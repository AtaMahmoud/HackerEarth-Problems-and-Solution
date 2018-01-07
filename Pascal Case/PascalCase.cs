using System;
 class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Enter a few words: ");
            var pascalCase = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(pascalCase)) 
                return;

            var variableName = "";
            foreach (var pCase in pascalCase.Split(' '))
            {
                var wordWithPascalCase = Char.ToUpper(pCase[0]) + pCase.ToLower().Substring(1);
                variableName += wordWithPascalCase;
            }
            Console.WriteLine(variableName);
            
        }
     }
