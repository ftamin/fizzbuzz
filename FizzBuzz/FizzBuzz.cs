using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz: IFizzBuzz
    {
        public string FizzBuzzValue(int i)
        {
            // Number divisible by 15(
            // divisible by both 3 & 5),
            // print 'FizzBuzz' in place
            // of the number
            if (i % 15 == 0)
            {
                return "FizzBuzz";
            }

            // Number divisible by 3,
            // print 'Fizz' in place
            // of the number
            else if (i % 3 == 0)
            {
                return "Fizz";
            }
            // Number divisible by
            // 5, print 'Buzz'
            // in place of the number
            else if (i % 5 == 0)
            {
                return "Buzz";
            }
            return i.ToString();
        }
    }
}
