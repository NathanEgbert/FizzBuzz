using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzClass
{
    public class FizzBuzz
    {

        int fizz = 3;
        int buzz = 5;

        public string evaluate(int num)
        {
            if (calculations(num, fizz) == 0 && calculations(num, buzz) == 0)
            {
                return "FizzBuzz";
            }

            else if (calculations(num, fizz) == 0 )
            {
                return "Fizz";
            }

            else if (calculations(num, buzz) == 0)
            {
                return "Buzz";
            }

            return num.ToString();

        }

        public int calculations(int num1, int divisor)
        {
            var result = num1 % divisor;
            return result;

        }

    }
}
