using System;

namespace main.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int i = 0;
            string s = "HI!";
            bool b = true;

            Console.WriteLine(i);
            Console.WriteLine(s);
            Console.WriteLine(b);

            Console.ReadLine();


            Console.WriteLine("Please enter age");
            int entry = Int32.Parse(Console.ReadLine());

            if (entry >= 18)
            { Console.WriteLine("You are an adult");
            
            }

            else if(entry < 18)
            {
                Console.WriteLine("You are a child.");
            }
        }
    }
}
