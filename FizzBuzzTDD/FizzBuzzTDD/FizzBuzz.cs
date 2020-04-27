using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTDD
{
    public class FizzBuzz
    {
        const string delimetedByThreeString = "Fizz";
        const string delimetedByFiveString = "Buzz";
        const string delimetedByFiveAndThreeString = delimetedByThreeString + delimetedByFiveString;

        public string ProcessNumber(int value)
        {
            if ((value % 3 == 0) && (value % 5 == 0)) return delimetedByFiveAndThreeString;
            else if (value % 3 == 0) return delimetedByThreeString;
            else if (value % 5 == 0) return delimetedByFiveString;
            else return value.ToString();
        }
    }
}
