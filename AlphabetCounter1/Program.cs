namespace AlphabetCounter1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a word: ");
            string word = Console.ReadLine();
            word = word.ToLower();

            Console.WriteLine("Write a lettter: ");
            char letter = Convert.ToChar(Console.ReadLine());
            letter = char.ToLower(letter);

            int counter = 0;

            foreach (var ch in word)
            {
                if (ch == letter)
                    counter++;
            }

            Console.WriteLine($"You have {counter} of letter {letter}");
        }
    }
}