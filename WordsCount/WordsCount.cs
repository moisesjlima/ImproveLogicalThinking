namespace WordsCount
{
    internal class WordsCount
    {
        static void Main(string[] args)
        {
            // Let's count the words that'll be input
            Console.Write("Words to be counted: ");
            string wordsInput = Console.ReadLine()!;

            int count = CountWords(wordsInput);

            string showCount = count > 1 ? $"You write {count} words"
                : $"You write one word: {wordsInput}";

            Console.WriteLine(showCount);
        }

        static int CountWords(string wordsInput)
        {
            string[] words = wordsInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
}