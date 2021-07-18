using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Task
{
        public class Calculator
{
    public static double Calculations(double number1, double number2, string op)
    {
        double result = double.NaN; // Default value is "not-a-number" which we use if an operation, such as division, could result in an error.

        // Use a switch statement to do the math.
        switch (op)
        {
            case "a":
                result = number1 + number2;
                break;
            case "s":
                result = number1 - number2;
                break;
            case "m":
                result = number1 * number2;
                break;
            case "q":
                result = Math.Pow (number1, 2);
                break;
            case "d":
                // Ask the user to enter a non-zero divisor.
                if (number2 != 0)
                {
                    result = number1 / number2;
                }
                break;
            // Return text for an incorrect option entry.
            default:
                break;
        }
        return result;
    }
}
    
}