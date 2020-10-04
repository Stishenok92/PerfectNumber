using System;
using System.ComponentModel.DataAnnotations;

namespace PerfectNumberLibrary
{
    public class PerfectNumber
    {
        public static int MIN_NATURAL_NUMBER = 1;

        public static bool ValidationNaturalNumber(int number)
        {
            return number >= MIN_NATURAL_NUMBER;
        }

        public static int CalculateSumDivisors(int number)
        {
            number = Math.Abs(number);
            int sum = 0;

            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        public static bool IsPerfectNumber(int number)
        {
            if (!ValidationNaturalNumber(number))
            {
                throw new ValidationException();
            }

            return number == CalculateSumDivisors(number);
        }
    }
}