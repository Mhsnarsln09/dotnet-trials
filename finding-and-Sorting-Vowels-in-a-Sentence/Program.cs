namespace finding_and_Sorting_Vowels_in_a_Sentence;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a sentence: ");
            string sentence = Console.ReadLine();
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            List<char> vowelList = new List<char>();

            foreach (char c in sentence)
            {
                if (Array.Exists(vowels, vowel => vowel == c))
                {
                    vowelList.Add(c);
                }
            }

            vowelList.Sort();

            Console.WriteLine("Vowels in the sentence: " + string.Join(", ", vowelList));
    }
}
