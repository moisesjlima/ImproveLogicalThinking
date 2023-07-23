namespace HangmanGame
{
    internal class HangmanGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------ Hangmen Game  ------------------");

            #region generate random word in a list
            List<string> wordList = new List<string>
            { "banana", "car", "grape", "watermelon", "smartphone", "software", "hardware", "mouse", "guitar", "pen", "book", "notepad", "videogame", "bug" };

            Random random = new();

            var indiceWordList = random.Next(0, wordList.Count);

            var word = wordList[indiceWordList];
            #endregion

            int maxAttempts = 5;

            var lettersFound = new Char[word.Length];

            for (var i = 0; i < word.Length; i++)
                lettersFound[i] = '_';

            int attempts = 0;

            var letterInput = new List<char>();

            while (true)
            {
            Again:
                Console.WriteLine();
                Console.WriteLine("Word to figure out:\n" + string.Join(" ", lettersFound));
                Console.WriteLine("type a word: ");
                char letter;

                try { letter = Convert.ToChar(Console.ReadLine().ToLower()); if (letterInput.Any(x => x == letter)) { Console.WriteLine("letter already typed"); goto Again; } }
                catch { Console.WriteLine("type just a charactere!"); goto Again; }

                letterInput.Add(letter);

                bool found = false;

                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i].ToString().ToLower() == letter.ToString().ToLower())
                    {
                        lettersFound[i] = letter;

                        found = true;
                    }
                };

                if (!found)
                {
                    attempts++;
                    Console.WriteLine("letter not found. attempts remaining: " + (maxAttempts - attempts));
                }

                if (attempts == maxAttempts)
                {
                    Console.WriteLine("You've lost! The word Was: " + word);
                    break;
                }

                if (string.Join("", lettersFound).ToLower() == word.ToLower())
                {
                    Console.WriteLine("Nice, you've found the word! =)\n" + word);
                    break;
                }

            }

        }
    }
}