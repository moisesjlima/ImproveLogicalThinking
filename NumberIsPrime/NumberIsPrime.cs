namespace NumberIsPrime
{
    internal class NumberIsPrime
    {
        static void Main(string[] args)
        {
            // The number prime is when the rest of division is zero when divided by one or itself

            Console.Write("Input a number to see if it's a number prime or not: ");
            var numberInput = int.Parse(Console.ReadLine()!);

            string isPrime = IsNumbersPrime(numberInput) ? $"The number {numberInput} is prime" : $"The number {numberInput} isn't prime";

            Console.WriteLine(isPrime);

            //Console.WriteLine("Is Prime: " + IsNumbersPrimeOld(numberInput));
        }

        private static bool IsNumbersPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        // Another way to verify if it's a prime number
        private static bool IsNumbersPrimeOld(int number)
        {
            if (number < 2)
                return false;

            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    count++;
            }

            if (count == 2)
                return true;
            else
                return false;
        }
    }
}