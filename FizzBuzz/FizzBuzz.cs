namespace FizzBuzz
{
    internal class FizzBuzz
    {
        static void Main(string[] args)
        {
            //FizzBuzz is an easy game to learn about division, especially for kids =)
            //Let's Start

            int fizzBuzz = 0;
            int fizz = 0;
            int buzz = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz: " + i);
                    fizzBuzz++;
                }
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz: " + i);
                    fizz++;
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz: " + i);
                    buzz++;
                }
            }
            Console.WriteLine("------------Total up to 100------------");
            Console.WriteLine("FizzBuzz: " + fizzBuzz
                + "| Fizz: " + fizz + "| Buzz: " + buzz);
        }
    }
}