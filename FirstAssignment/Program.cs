using System;

namespace FirstAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)



            {
                Console.WriteLine("Console Calculator in C#\r");
                Console.WriteLine("------------------------\n");


                Console.WriteLine("Type a number, and then press Enter");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type in a second nunber and then press enter");
                int num2 = Convert.ToInt32(Console.ReadLine());

                // Ask the user to choose an option.
                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option? \n");

                String userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "a":
                        Console.WriteLine($"Your result: {num1} + {num2} = " + addition(num1, num2));
                        break;
                    case "s":
                        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                        break;
                    case "m":
                        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                        break;
                    case "d":
                        // Ask the user to enter a non-zero divisor until they do so.
                        while (num2 == 0)
                        {
                            Console.WriteLine("Enter a non-zero divisor: ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                        break;
                }

            }


        }

        public static int addition(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int subtraction(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int divide(int num1, int num2)
        {
            //if (args.num1 = 10)
            //{
            //    Console.WriteLine("Please enter a numeric argument.");
            //    return addition;

            //}

            //if (args.num2 > 0)
            //{
            //    Console.WriteLine("Please enter a numeric argument.");
            //    return subtraction; if (args.num2 == 0)
            //    {
            //        Console.WriteLine("Please enter a numeric argument.");
            //        return division;
            //    }


            //}

            return num2 / num2;


        }


    }

           
}




