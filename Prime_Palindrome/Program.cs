using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Palindrome
{
    public static class PrimeTool
    {
        // Test whether the number is a prime number.
        public static bool IsPrime(int number)
        {
            if ((number & 1) == 0)
            {
                if (number == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            for (int i = 3; (i * i) <= number; i += 2)
            {
                if ((number % i) == 0)
                {
                    return false;
                }
            }
            return number != 1;
        }
    }

    class Program
    {
        // Tests whether a string is a palindrome
        public static bool IsPalindrome(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }

        static void Main(string[] args)
        {
            const int limit = 1000; 
            int biggest_prime_palindrome = 0;

            // Find biggest prime palindrome under the limit and output it
            for (int i = 0; i < limit; i++)
            {
                bool prime = PrimeTool.IsPrime(i);
                bool palindrome = IsPalindrome(Convert.ToString(i));
                if (prime && palindrome)
                {
                    biggest_prime_palindrome = i;
                }
            }

            Console.WriteLine(biggest_prime_palindrome);
        }
    }



}
