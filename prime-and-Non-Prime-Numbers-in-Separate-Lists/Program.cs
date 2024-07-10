using System.Collections;

namespace prime_and_Non_Prime_Numbers_in_Separate_Lists;

class Program
{
    static void Main(string[] args)
    {
        ArrayList primeList = new ArrayList();
        ArrayList nonPrimeList = new ArrayList();

        int count = 0;

        while (count < 20)
        {
            Console.Write($"Please enter positive number {count + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
            {
                if (IsPrime(number))
                {
                    primeList.Add(number);
                }
                else
                {
                    nonPrimeList.Add(number);
                }
                count++;
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a positive number.");
            }
        }
            primeList.Sort();
            primeList.Reverse();
            nonPrimeList.Sort();
            nonPrimeList.Reverse();

            Console.WriteLine("Prime Numbers (Descending): " + string.Join(", ", primeList.Cast<int>()));
            Console.WriteLine("Non-Prime Numbers (Descending): " + string.Join(", ", nonPrimeList.Cast<int>()));

            Console.WriteLine($"Number of prime numbers: {primeList.Count}, Average: {primeList.Cast<int>().Average()}");
            Console.WriteLine($"Number of non-prime numbers: {nonPrimeList.Count}, Average: {nonPrimeList.Cast<int>().Average()}");
    }

    static bool IsPrime(int number)
    {
        if (number == 1) return false;
        if (number == 2) return true;

        for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
        {
            if (number % i == 0) return false;
        }

        return true;
    }

}
