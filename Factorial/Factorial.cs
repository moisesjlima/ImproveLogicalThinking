namespace Factorial
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            // Input a number to see its factorial
            Console.Write("Input a number to see its factorial: ");
            var numberInput = int.Parse(Console.ReadLine()!);

            Console.WriteLine("\n------------------Result------------------");
            Console.Write(CalculateFactorial(numberInput));
            Console.WriteLine();
        }

        private static long CalculateFactorial(int number)
        {
            if (number <= 0)
                throw new ArgumentException("the number must be non-negative and greater than 0 !");

            long factorial = number;

            Console.Write(factorial + "! = " + number + " X ");

            for (int i = 1; i < number; i++)
            {
                factorial *= (number - i);
                if ((number - i) == 1)
                    Console.Write((number - i) + " = ");
                else
                    Console.Write((number - i) + " X ");
            }

            return factorial;
        }
    }
}