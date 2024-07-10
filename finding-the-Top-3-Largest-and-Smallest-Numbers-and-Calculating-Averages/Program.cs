namespace finding_the_Top_3_Largest_and_Smallest_Numbers_and_Calculating_Averages;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[20];
        int count = 0;

        while (count < 20)
        {
            Console.Write($"Please enter number {count + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                numbers[count] = number;
                count++;
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a number.");
            }
        }

        var largestThree = numbers.OrderByDescending(x => x).Take(3).ToArray();
        var smallestThree = numbers.OrderBy(x => x).Take(3).ToArray();

        double largestThreeAverage = largestThree.Average();
        double smallestThreeAverage = smallestThree.Average();
        double totalAverage = largestThreeAverage + smallestThreeAverage;

        Console.WriteLine("Top 3 Largest Numbers: " + string.Join(", ", largestThree));
        Console.WriteLine("Top 3 Smallest Numbers: " + string.Join(", ", smallestThree));

        Console.WriteLine($"Average of top 3 largest numbers: {largestThreeAverage}");
        Console.WriteLine($"Average of top 3 smallest numbers: {smallestThreeAverage}");
        Console.WriteLine($"Sum of averages: {totalAverage}");
    }
}
