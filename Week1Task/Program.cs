using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week1Task
{
class Program
{
    static void Main(string[] args)
    {
        
        bool endApp = false;
        // Display title as the C# console calculator app.
        Console.WriteLine("Console Calculator in C#\r");
        Console.WriteLine("------------------------\n");

        while (!endApp)
        {
            // Declare variables
            string numberInput1;
            string numberInput2;
            double result; 

            // Ask the user to type the first number.
            Console.Write("Type a number, and then press Enter: ");
            numberInput1 = Console.ReadLine();

            double cleanNumber1 = 0;
             // if not a valid double return the string. tryparse converts string rep of a number to its double
            while (!double.TryParse(numberInput1, out cleanNumber1))
            {
                Console.Write("This is not valid input. Please enter an integer value: ");
                numberInput1 = Console.ReadLine();
            }

            // Ask the user to type the second number.
            Console.Write("Type another number, and then press Enter: ");
            numberInput2 = Console.ReadLine();

            double cleanNumber2 = 0;
            while (!double.TryParse(numberInput2, out cleanNumber2))
            {
                Console.Write("This is not valid input. Please enter an integer value: ");
                numberInput2 = Console.ReadLine();
            }

            // Ask the user to choose an operator.
            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\tq - Square-root");
            Console.WriteLine("\td - Divide");
            Console.Write("Select corresponding alphabet and press enter ");

            string op = Console.ReadLine();

            try
            {
                result = Calculator.Calculations(cleanNumber1, cleanNumber2, op);
                if (double.IsNaN(result))
                {
                    Console.WriteLine("This operation will result in a mathematical error.\n");
                }
                // result set to a maximum of 2 decimal place with string
                else Console.WriteLine("Your result: {0:0.##}\n", result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
            }


            List <ViewHistory> list = new List<ViewHistory>();
            list.Add(new ViewHistory());
            list[0].Values = 3.5.ToString();

            list.Add(new ViewHistory());
            list[1].Values = 8.ToString();

          foreach (ViewHistory item in list)
          {
              Console.WriteLine(item.getData());
          }


            Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
            if (Console.ReadLine() == "n") endApp = true;

            Console.WriteLine("\n"); 
        }
        return;


            
           
        }
    }
}