namespace ArraysManipulations
{
    internal class ArraysManipulations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------Array Manipulations-----------");
            Console.WriteLine("Manipulating int[]");
            var numbers = new int[10];
            numbers[0] = 10; numbers[1] = 5; numbers[3] = 5; ; numbers[4] = 30; numbers[5] = 5;
            numbers[6] = 5; numbers[7] = 10; ; numbers[8] = 20; ; numbers[9] = 0;

            Console.WriteLine("Sum: " + SumArrayValues(numbers));
            var result = LargestNumber(numbers) is not null ? "Largest Number in Array: " + LargestNumber(numbers) : "Array is empty";
            Console.WriteLine(result);
            Console.WriteLine();

            Console.WriteLine("Manipulating string[]");

            var fruits = ReturnFruits();
            Console.WriteLine(Array.IndexOf(fruits, "orange"));

            var fruitExist = Array.Exists(fruits, f => f.Contains("nana"));
            Console.WriteLine(fruitExist);

            Console.WriteLine(Array.Find(fruits, f => f.Contains("pina")));

            var findAllFruits = Array.FindAll(fruits, f => f.Contains("an"));
            Array.ForEach(findAllFruits, a => Console.Write(a + "\n"));

            Array.Reverse(fruits);

            Array.ForEach(fruits, a => Console.Write(a + "\n"));
            Console.WriteLine();

            var fruitsCopy = new string[fruits.Length];
            Array.Copy(fruits, fruitsCopy, 5);
            Array.ForEach(fruitsCopy, a => Console.Write(a + "\n"));

            Array.Sort(fruitsCopy);
            Console.WriteLine("Asc");

            Array.ForEach(fruitsCopy, a => Console.Write(a + "\n"));
            Console.WriteLine();

            Console.WriteLine("Binary Search");
            ArrayBinarySearch(fruits, "banana");

        }

        private static int SumArrayValues(int[] values)
        {
            int sum = 0;
            for (var i = 0; i < values.Length; i++)
                sum += values[i];

            return sum;
        }

        private static int? LargestNumber(int[] values)
        {
            int max = 0;

            if (values.Length >= 0)
            {
                max = values[0];

                for (var i = 1; i < values.Length; i++)
                {
                    if (values[i] > max)
                        max = values[i];
                }
            }

            if (max == 0)
                return null;

            return max;
        }

        private static string[] ReturnFruits()
        {
            var fruits = new[] { "melon", "banana", "watermelon", "orange", "pinaple", "aple" };

            return fruits;
        }

        public static void ArrayBinarySearch(string[] array, string search)
        {
            Array.Sort(array);

            var index = Array.BinarySearch(array, search);

            if (index == -1)
                Console.WriteLine("nothing");
            else
                Console.WriteLine(index);
        }
    }
}