using System;

public class Calculator
{
    public static void Main(string[] args)
    {
        string restart;
        do
        {
            double num1;
            double num2;
            string op;
            double res;

			
            try
            {
                Console.Write("Enter number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number: ");
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Not a number");
                Main(args);
                break;
            }
            Console.Write("Enter operator(+,-,*,/,^): ");
            op = Console.ReadLine();
            switch (op)
            {
                case "+":
                    res = num1 + num2;
                    Console.WriteLine("Result: " + res);
                    break;

                case "-":
                    res = num1 - num2;
                    Console.WriteLine("Result: " + res);
                    break;

                case "*":
                    res = num1 * num2;
                    Console.WriteLine("Result: " + res);
                    break;

                case "/":
                    res = num1 / num2;
                    Console.WriteLine("Result: " + res);
                    break;

                case "^":
                    res = Math.Pow(num1, num2);
                    Console.WriteLine("Result: " + res);
                    break;

                default:
                    Console.WriteLine("INVAILD OPERATOR");
                    break;
            }
            Console.Write("Do you wanna restart y/n:");
            restart = Console.ReadLine();
            Console.Clear();
        } while (restart == "y" || restart == "Y");
    }
}
