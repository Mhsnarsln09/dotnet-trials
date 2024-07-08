namespace print_the_numbers_that_are_equal_to_or_divisible_by;

class Program
{
    static void Main(string[] args)
    {
         Console.Write("Enter a positive number (n): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter a positive number (m): ");
        int m = int.Parse(Console.ReadLine());

        List<int> numbers = new List<int>();

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter a positive number: ");
            int number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        Console.WriteLine($"Numbers that are equal to or divisible by {m}:");
        foreach (int number in numbers)
        {
            if (number == m || number % m == 0)
            {
                Console.WriteLine(number);
            }
        }
    }
}
