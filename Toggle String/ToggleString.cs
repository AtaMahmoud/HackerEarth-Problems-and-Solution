using System;
namespace StringToggle
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] name = Console.ReadLine().ToCharArray();
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] >= 'A' && name[i] <= 'Z')
                {
                    name[i] = (char)(name[i] + 32);
                    Console.Write(name[i]);
                }
                else if (name[i] >= 'a' && name[i] <= 'z')
                {
                    name[i] = (char)(name[i] - 32);
                    Console.Write(name[i]);
                }
            }

        }
            
    }
}
