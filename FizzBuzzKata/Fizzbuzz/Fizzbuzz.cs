using System;

namespace Fizzbuzz
{
    public class Fizzbuzz
    {
        public Fizzbuzz()
        {
            Console.WriteLine("init");
        }

        public string DoStuff(int number)
        {
            // Special case that would return a 0 module too
            if (number == 0)
            {
                return "0";
            }

            string phrase = "" + number;
            bool fizzbuzz = false;

            if (DivisibleByThree(number))
            {
                if (!fizzbuzz)
                {
                    fizzbuzz = true;
                    phrase = "fizz";
                }
                else
                {
                    phrase = phrase + "fizz";
                }
            }

            if (DivisibleByFive(number))
            {
                if (!fizzbuzz)
                {
                    fizzbuzz = true;
                    phrase = "buzz";
                }
                else
                {
                    phrase = phrase + "buzz";
                }
            }

            return phrase;
        }

        private bool DivisibleByThree(int number)
        {
            return ((number % 3) == 0);
        }

        private bool DivisibleByFive(int number)
        {
            return ((number % 5) == 0);
        }
    }


    // Driver Class 
    public class Program
    {

        // Main Method 
        static public void Main()
        {
            Console.WriteLine("I'm here");
        }
    }

}