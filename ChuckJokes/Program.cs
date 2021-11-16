using System;
using System.IO;

namespace ChuckJokes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of jokes");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            GetJokes(userNumber);

            
        }
        public static void GetJokes(int numberofjokes)
        {
            string filePath = @"C:\Users\opilane\Sample\chuck.txt";
            string[] jokesAboutChuck = File.ReadAllLines(filePath);

            if(numberofjokes > jokesAboutChuck.Length)
            {
                numberofjokes = jokesAboutChuck.Length;
            }

            for(int i = 0; i < numberofjokes; i++)
            {
                Console.WriteLine(jokesAboutChuck);
            }
            
        }
    }
}
