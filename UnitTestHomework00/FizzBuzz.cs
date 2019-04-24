using System;
using System.Text;
using UnitTestHomework00.Core.Common;

namespace UnitTestHomework00
{
    public class FizzBuzz
    {
        public string Handle(int number)
        {
            var sb = new StringBuilder();

            if(number % 3 == 0)
            {
                sb.Append(Constants.Fizz);
            }
            if(number % 5 == 0)
            {
                sb.Append(Constants.Buzz);
            }

            return sb.ToString();
        }
    }
}
