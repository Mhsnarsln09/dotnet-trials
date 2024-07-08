namespace even_number_print;

class Program
{
    static void Main()
    {
       
        List<int> numbers = new List<int>();

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter a positive number: ");
            int number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        Console.WriteLine("Even numbers:");
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine(number);
            }
        }
    }
}
