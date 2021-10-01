using System;
using System.Collections.Generic;

namespace Kata
{
    public class FizzBuzzClass
    {
        public string GetFizzBuzz(int number)
        {
            string fizzBuzz = "";

            fizzBuzz += AddFizzIfDivisibleBy3(number);
            fizzBuzz += AddBuzzIfDivisibleBy5(number);
            fizzBuzz = AddNumberAsStringIfItWasNotDivisible(fizzBuzz, number);            

            return fizzBuzz;
        }

        public List<string> GetFizzBuzzList(int listLength)
        {
            List<string> fizzBuzzList = new List<string>();
            for (int i = 0; i < listLength; i++)
            {
                fizzBuzzList.Add(GetFizzBuzz(i));
            }

            return fizzBuzzList;
        }

        private string AddFizzIfDivisibleBy3(int number) => (number % 3 == 0) ? "Fizz" : "";

        private string AddBuzzIfDivisibleBy5(int number) => (number % 5 == 0) ? "Buzz" : "";

        private string AddNumberAsStringIfItWasNotDivisible(string fizzBuzz, int number)
        {
            if (fizzBuzz == "") fizzBuzz = number.ToString();
            return fizzBuzz;
        }
    }
}
