namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            // Fibonacci sequence
            // the number start with 0 1 1 and the next numbers is the sum of the two previous numbers, exemplo: 1 1 2 3 5 8 13 21... (1 + 1) = 2 (2 + 1) = 3 ....
            // * We use fibonacci sequence on story points in Azure DevOps to rank the task 
            int terms = 20;

            Console.WriteLine($"fibonacci in position {terms}: " + FibonacciSequenceRecursion(20)); //Using recursion

            Console.WriteLine();

            Console.WriteLine("Fibonacci Sequence:");
            foreach (int number in FibonacciSequence(terms + 1))
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }

        private static int[] FibonacciSequence(int terms)
        {
            try
            {
                int[] fibonacciSequence = new int[terms];

                if (terms >= 1)
                {
                    fibonacciSequence[0] = 0;
                }

                if (terms >= 2)
                {
                    fibonacciSequence[1] = 1;
                }

                for (int i = 2; i < terms; i++)
                {
                    fibonacciSequence[i] = fibonacciSequence[i - 1] + fibonacciSequence[i - 2];
                }

                return fibonacciSequence;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Just an another way to do using yield return
        private static IEnumerable<int> FibonacciSequenceOld(int terms)
        {
            int[] fibonacciSequence = new int[terms];

            if (terms >= 1)
            {
                yield return fibonacciSequence[0] = 0;
            }

            if (terms >= 2)
            {
                yield return fibonacciSequence[1] = 1;
            }

            for (int i = 2; i < terms; i++)
            {
                yield return fibonacciSequence[i] = fibonacciSequence[i - 1] + fibonacciSequence[i - 2]; //yield return cannot be in try catch block
            }
        }

        private static int FibonacciSequenceRecursion(int number)
        {
            if (number == 0 || number == 1)
                return number;

            return FibonacciSequenceRecursion(number - 1) + FibonacciSequenceRecursion(number - 2);
        }

    }
}