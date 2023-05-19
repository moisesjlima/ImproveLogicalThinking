namespace ReverseString
{
    internal class ReverseString
    {
        static void Main(string[] args)
        {
            //Just to get any string/word and reverse it ;)

            Console.Write("Write any word to reverse it: ");
            string word = Console.ReadLine()!;

            Console.WriteLine("result: " + StringToReverse(word));

        }

        static string StringToReverse(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}