using System;
using System.IO;

namespace FruitAndVegetables
{
    class Program
    {
        static void Main(string[] args)
        {
            //read data from fruit.txt
            string fruitPath = @"C:\Users\opilane\Sample\fruit.txt";
            string[] veggieData = File.ReadAllLines(fruitPath);

            string veggiePath = @"C:C:\Users\opilane\Sample\veggie.txt";
            string[] fruitData = File.ReadAllLines(veggiePath);

            File.WriteAllLines(fruitPath, fruitData);
            File.WriteAllLines(veggiePath, veggieData);


        }
    }
}
