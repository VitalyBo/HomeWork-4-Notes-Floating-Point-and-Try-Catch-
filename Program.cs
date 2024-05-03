using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Сonsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.Unicode;

            float convert_to_Fahrenheit(float x)
            {
                return (float)x * 9 / 5 + 32;
            };

            while (true)
            {
                int choice = 0;

                Console.WriteLine("1.Float Type Declaration and Usage\n2.Explicit and Implicit Casting\n3.Parsing Strings to Numbers\n4.Integral and Double Math Operations\n5.Rounding Numbers\n6.Error Handling with Try-Catch Blocks\n7.Exit from program");
                Console.WriteLine("\nChoose and put number from 1 to 7");

                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("1. Write a method where the user is asked to enter a " +
                        "temperature in Celsius. Declare this temperature as a float and " +
                        "convert it to Fahrenheit using the formula F = C * 9/5 + 32. " +
                        "Print the result as a float.\n");
                    Console.WriteLine("Put some number, this will be temperature in Celsius: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    float celsius = float.Parse(Console.ReadLine());
                    float fahrenheit = convert_to_Fahrenheit((float)celsius);
                    Console.WriteLine("The temperature in Fahrenheit is: " + fahrenheit);
                    Console.ResetColor();
                    Console.ReadKey();
                    continue;

                }

                if (choice == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("2. Task: Create a program that defines an integer and " +
                        "a double. Perform both explicit and implicit casting:\r\nImplicit: " +
                        "Assign the integer to a double.\r\nExplicit: Assign the double to " +
                        "an integer and display both values. Discuss what happens with the " +
                        "data during explicit casting.\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Put some integer number: ");
                    int Int = int.Parse(Console.ReadLine());
                    Console.WriteLine("Put some double number: ");
                    double Double = double.Parse(Console.ReadLine());
                    double implicit_Result = Int;  // Implicit casting: Assign the integer to a double                   
                    int explicit_Result = (int)Double; // Explicit casting: Assign the double to an integer

                    Console.WriteLine("Implicit Casting Result:");
                    Console.WriteLine($"Integer value (myInt):  {Int}");
                    Console.WriteLine($"Double value after implicit casting (implicitResult): + {implicit_Result}");

                    Console.WriteLine("\nExplicit Casting Result:");
                    Console.WriteLine($"Double value (myDouble):   {Double}");
                    Console.WriteLine($"Integer value after explicit casting (explicitResult): + {explicit_Result}");

                    Console.WriteLine("\nDuring explicit casting from double to int, the fractional " +
                        "part is truncated, and only the integer part is retained. This means that " +
                        "any decimal portion of the double value is discarded, leading to potential " +
                        "loss of precision. In the example provided, the value 20.5 is cast to an " +
                        "integer, resulting in 20, as the decimal part (.5) is truncated.");

                    Console.ResetColor();
                    Console.ReadKey();
                    continue;
                }

                if (choice == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("3. Task: Prompt the user to input two strings that represent " +
                        "integers. Parse these strings to integers safely using int.TryParse. If " +
                        "the parsing is successful, print the sum of these two integers. If not, " +
                        "print an error message.");
                    Console.ForegroundColor = ConsoleColor.Red;
                    while (true)
                    { 
                    Console.WriteLine("Put first integer:");
                    string integer_1 = Console.ReadLine();
                    Console.WriteLine("Put second integer:");
                    string integer_2 = Console.ReadLine();

                    int num1, num2;
                    if (int.TryParse(integer_1, out num1) && int.TryParse(integer_2, out num2))
                    {
                        int sum = num1 + num2;
                        Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error: Please enter valid integer values.");
                        continue;
                    }
                    }
                    Console.ResetColor();
                    Console.ReadKey();
                    continue;
                }

                if (choice == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("4.Task: Write a method that calculates the area of a circle. " +
                        "The user should input the radius as a double. Use the formula " +
                        "Area = π * r^2 (π can be approximated as 3.14159). " +
                        "Print the result using integral and double calculations:" +
                        "\r\nIntegral Calculation: Cast the radius to an integer before " +
                        "computing the area.\r\nDouble Calculation: Use the radius as a " +
                        "double to compute the area.\r\nCompare and discuss the results " +
                        "from the integral and double calculations. ");

                    static double calculate_circle_area_integral(double radius)
                    {
                        int radius_Int = (int)radius; // Casting radius to an integer
                        double area = 3.14159 * radius_Int * radius_Int;
                        return area;
                    }
                    static double calculate_circle_area_double(double radius)
                    {
                        double area = 3.14159 * radius * radius;
                        return area;
                    }
                        Console.WriteLine("Enter the radius of the circle:\n");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    double radius = double.Parse(Console.ReadLine());

                        double integral_area = calculate_circle_area_integral(radius);
                        double double_area = calculate_circle_area_double(radius);
                    Console.WriteLine($"\nResult for integer: {integral_area}");
                    Console.WriteLine($"Result for double: {double_area}");
                    Console.ResetColor();
                    Console.ReadKey();
                    continue;
                }

                if (choice == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("5. Ask the user to enter a floating-point number. " +
                        "Round this number to the nearest whole number and also to " +
                        "two decimal places using Math.Round. Display both rounded " +
                        "values and explain the differences in the results.");
                    Console.WriteLine("Put some floating-point number:");

                    double number = double.Parse(Console.ReadLine());  
                    double round_to_wholeNumber = Math.Round(number);                                   
                    double round_two_decimals = Math.Round(number, 2);

                    Console.WriteLine($"Rounded to the nearest whole number: {round_to_wholeNumber}");
                    Console.WriteLine($"Rounded to two decimal places: {round_two_decimals}");

                    Console.WriteLine("\nThe difference in the results is due to how the rounding " +
                        "is performed. When rounding to the nearest whole number, the number is rounded " +
                        "to the nearest integer. However, when rounding to two decimal places, the number " +
                        "is rounded to the nearest hundredth (two decimal places), which may result in a " +
                        "different value than rounding to the nearest whole number.");
                    Console.ResetColor();
                    Console.ReadKey();
                    continue;
                }

                if (choice == 6)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("6. Prompt the user to input a decimal number. " +
                        "Use decimal.TryParse to parse the input. If the parsing " +
                        "fails, use a try-catch block to catch the error and print " +
                        "an appropriate error message. If successful, display the " +
                        "decimal number formatted as currency");

                    Console.Write("\nPut length in centimeters: ");
                    double centimeters = double.Parse(Console.ReadLine());
                    double inches = centimeters / 2.54;
                    int rounded_inches = (int)Math.Round(inches);
                    int yards = rounded_inches / 36;
                    int inche_safter_yards = rounded_inches % 36;
                    int feet = inche_safter_yards / 12;
                    int last_inches = inche_safter_yards % 12;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n{yards} yard(s), {feet} feet, and {last_inches} inch(es).");
                    Console.ResetColor();
                    Console.ReadKey();
                    break;
                }
                if (choice == 7)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("7.Exit. Thank you for using our sofware!");
                    Console.ResetColor();
                    Console.ReadKey();
                    break;
                                        
                }
                else
                {
                    Console.Write("\nUuuuuups something going wrong! Try again!");
                    continue;
                }

                
                

            }


        }


    }
};

/*1.What are the two primary floating-point types in C#?
 * 
Float and double are two primitive data types in C#
programming that are used to store decimal values.
They both store floating point numbers but they differ in
the level of precision to which they can store the values.*/

/*2. What is the difference between float and double in C#?
 * 
 Use float or double ? The precision of a floating point value indicates 
how many digits the value can have after the decimal point. The precision
of float is only six or seven decimal digits, while double variables have
a precision of about 15 digits. Therefore it is safer to use double for 
most calculations.
 */

/*3. Why is it generally recommended to use double instead of float 
  for floating-point arithmetic?
  
Since double provides greater precision, the use cases are distinct compared
to float. Here are some examples in which double would be suitable instead
of float: Financial calculations: Since precision is a key here, double is
preferred in financial calculations to avoid rounding errors.*/

/*How does C# represent floating-point numbers internally?
 * 
 To declare a “float” variable in C#, you can use the “float” keyword 
followed by the variable name. Here's an example: float myFloat = 3.14f; 
Note that you need to append the “f” suffix to the float value to indicate
that it is a float and not a double 
 */

/*What are some common issues or considerations when performing arithmetic 
operations with floating-point numbers in C#?
  
If you add very big values to very small values, you can get inaccurate 
results (the small numbers get lost!) you can't represent very large 
integers as floating numbers.Floating-point numbers lose precision even 
when you are just working with such seemingly harmless numbers like 0.2 or 
76.5. You should be extra careful when working with a large amount of floating-point 
operations over the same data as errors may build up rather quickly.*/