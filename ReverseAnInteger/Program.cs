using System;

namespace ReverseAnInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse an integer!");
            Console.WriteLine("-------------------");

            Console.WriteLine("Enter the number to be reversed");
            try
            {
                Console.WriteLine("The reverse of the entered number is " +
                IntegerUtility.GetReverseOfANumber(int.Parse(Console.ReadLine().Trim()))
                );
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }
            Console.ReadLine();
        }
    }
}
