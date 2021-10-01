using System;
using System.Collections.Generic;

namespace Kata
{
    public class FizzBuzzClass
    {
        public string GetFizzBuzz(int number)
        {
            string fizzBuzz = "";

            if (number % 3 == 0) fizzBuzz += "Fizz";
            if (number % 5 == 0) fizzBuzz += "Buzz";
            if (fizzBuzz == "") fizzBuzz = number.ToString();

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
    }
}
