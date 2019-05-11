using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseAnInteger
{
    class IntegerUtility
    {
        public static int GetReverseOfANumber(int number) {
            if (number < 10) {
                return number;
            }
            try
            {
                String result = "";
                while (number != 0)
                {
                    int quotient = number / 10;
                    int remainder = number % 10;
                    number = quotient;
                    result = result + remainder.ToString();
                }
                number = int.Parse(result.Trim());
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }
            return number;
        }
    }
}
