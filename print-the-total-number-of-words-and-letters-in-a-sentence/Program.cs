namespace print_the_total_number_of_words_and_letters_in_a_sentence;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        string[] words = sentence.Split(' ');
        int wordCount = words.Length;

        int letterCount = 0;
        foreach (string word in words)
        {
            letterCount += word.Length;
        }

        Console.WriteLine($"Total number of words: {wordCount}");
        Console.WriteLine($"Total number of letters: {letterCount}");
    }
}
