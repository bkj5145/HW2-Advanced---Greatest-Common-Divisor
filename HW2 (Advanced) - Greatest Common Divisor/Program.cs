using System;

namespace HW2__Advanced____Greatest_Common_Divisor
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1;
            int number2;
            int remainder = 0;

            Console.Write("Please enter a value for the first number: ");
            while(Int32.TryParse(Console.ReadLine(), out number1)==false)
            {
                Console.Write("This is not an integer.  Give me a number please! ");
            }
            Console.Write("Please enter a value for the second number: ");
            while (Int32.TryParse(Console.ReadLine(), out number2) == false)
            {
                Console.Write("This is not an integer.  Give me a number please! ");
            }

            if (number1 >= number2)
            {
                if (number1 % number2 == 0)
                {
                    Console.WriteLine(number2 + " is the GCD");
                }
                else if (number1 % number2 !=0)
                {
                    
                    while (number1 % number2 != 0)
                    {
                        remainder = number1 % number2;
                        number1 = number2;
                        number2 = remainder;

                    }
                    
                    Console.WriteLine(remainder + " is the GCD");
                }
            }
            if (number2 >= number1)
            {
                if (number2 % number1 == 0)
                {
                    Console.WriteLine(number1 + " is the GCD");
                }
                else if (number2 % number1 != 0)
                {
                    while (number2 % number1 != 0)
                    {
                        remainder = number2 % number1;
                        number2 = number1;
                        number1 = remainder;

                    }

                    Console.WriteLine(remainder + " is the GCD");
                }
            }


            Console.ReadLine();

        }
    }
}
