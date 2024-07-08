namespace print_the_words_entered_by_the_user_in_reverse_order;

class Program
{
    static void Main()
    {
         Console.Write("Enter a positive number (n): ");
        int n = int.Parse(Console.ReadLine());

        List<string> words = new List<string>();

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            words.Add(word);
        }

        Console.WriteLine("Words in reverse order:");
        words.Reverse();
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}
