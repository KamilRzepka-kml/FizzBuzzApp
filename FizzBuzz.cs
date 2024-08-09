using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApp
{
    internal class FizzBuzz
    {
        public string GetNumber(int number)
        {

            if (number % 15 == 0)

                return "FizzBUzz";

            if (number % 3 == 0)

                return "Fizz";

            if (number % 5 == 0)

                return "Buzz";

            return number.ToString();

        }

        //public string GetNumber(int number)
        //{
        //    var result = string.Empty;
        //    if (number % 15 == 0)
        //    {
        //        result = "FizzBUzz";
        //    }

        //    else if (number % 3 == 0)
        //    {
        //        result = "Fizz";
        //    }

        //    else if (number % 5 == 0)
        //    {
        //        result = "Buzz";
        //    }

        //    return result;

        //}
    }
}
