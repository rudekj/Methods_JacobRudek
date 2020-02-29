using System;

namespace Methods_JacobRudek
{
    class Program
    {
        static void MyMethod()

        {
            //first number

            Console.WriteLine("Please enter your first number");
            string number1;
            int num1;
            number1 = Console.ReadLine();
            num1 = Convert.ToInt32(number1);


            //second number

            Console.WriteLine("Please enter your second number");
            string number2;
            int num2;
            number2 = Console.ReadLine();
            num2 = Convert.ToInt32(number2);



            //choice of arithmetic operations

            Console.WriteLine("Choose an arithmetic operation and enter the corresponding number to execute" 
                + "    " + "0 is addition" +"   " + "1 is subtraction" + "   " + "2 is multiplication" + "    " + "3 is division" );
            string operationchoice;
            int operationint;
            operationchoice = Console.ReadLine();
            operationint = Convert.ToInt32(operationchoice);


            // If addition is selected

            if (operationint == 0)
            {
                int sum;
                sum = num1 + num2;
                Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum);
            }

            // If subtraction is selected
            else if (operationint == 1)
            {
                int difference;
                difference = num1 - num2;
                Console.WriteLine("The difference of " + num1 + " and " + num2 + " is " + difference);
            }

            // If multiplication is selected
            else if (operationint == 2)
            {
                int product;
                product = num1 * num2;
                Console.WriteLine("The product of " + num1 + " and " + num2 + " is " + product);
            }

            else if (operationint == 3 && num2 == 0)
            {
                Console.WriteLine("Diving by zero is not allowed. Please try again");
            }

            // If division is selected
            else if (operationint == 3)
            {
                int quotient;
                quotient = num1 / num2;
                Console.WriteLine("The quotient of " + num1 + " and " + num2 + " is " + quotient);
            }

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello! My Name is Jacob Rudek");
            MyMethod();





        }


    }

}
