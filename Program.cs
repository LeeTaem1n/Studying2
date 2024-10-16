using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input consecutive numbers separated by space or comma:");
        string input = Console.ReadLine();

        // Define dividers as space and comma
        char[] dividers = { ',', ' ' };
        string[] segments = input.Split(dividers, StringSplitOptions.RemoveEmptyEntries);

        int sum = 0;

        // Loop through the segments and sum the valid numbers
        foreach (string s in segments)
        {
            if (s.Length > 0 && IsAllDigits(s))
            {
                if (Int32.TryParse(s, out int num))
                {
                    Console.WriteLine("Next number = {0}", num);
                    sum += num;
                }
            }
        }

        Console.WriteLine("Sum = {0}", sum);
        Console.WriteLine("Press 'Enter' to exit.");
        Console.ReadLine();  // Corrected Read() to ReadLine() for proper input capture.
    }

    // Method to check if the string contains only digits
    private static bool IsAllDigits(string raw)
    {
        string s = raw.Trim();
        if (s.Length == 0)
        {
            return false;
        }

        for (int index = 0; index < s.Length; index++)
        {
            if (!char.IsDigit(s[index]))
            {
                return false;
            }
        }
        return true;
    }
}
