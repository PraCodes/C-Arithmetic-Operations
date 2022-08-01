// See https://aka.ms/new-console-template for more information
namespace Pracodes
{
    class Programs
    {
        static void Main(string []args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Let's carry out simple operations");
            Console.WriteLine("You are to input two numbers, Let's go!");
            Console.WriteLine("Input the first number below");
            int a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number below");
            int b= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Sum of numbers is" + (a + b));
            //Console.WriteLine("Input M for multiplication Operation");
            //Console.ReadLine();
            //string M = Multiplication
            Console.WriteLine( ("Multiplication of your inputs \n") + (a * b));
            Console.WriteLine( ("Division of your inputs \n") +  (a / b));
            Console.WriteLine( ("Addition of your inputs \n") +  (a + b));
            Console.WriteLine( ("Subtraction of your inputs \n") + (a - b));
            Console.WriteLine( ("Ratio of your inputs \n") + (a % b));


        }
    }
}