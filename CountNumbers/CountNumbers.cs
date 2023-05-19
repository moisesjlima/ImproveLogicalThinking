namespace CountNumbers
{
    internal class CountNumbers
    {
        static void Main(string[] args)
        {
            // Give a number to start counting and the end of number to stop counting *using yield return

            Console.Write("Input a number to Start: ");
            var numberStart = int.Parse(Console.ReadLine()!);
            Console.Write("Input a number to End the counting: ");
            var numberEnd = int.Parse(Console.ReadLine()!);

            var count = NumberCount(numberStart, numberEnd);

            foreach (var counting in count)
                Console.Write(counting + " ");
        }

        private static IEnumerable<int> NumberCount(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                yield return i;
            }
        }
    }
}