using System;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        string message = "";

        while (true)
        {
            Console.Write("Enter something: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Closing Program...");
                break;
            }

            int num;
            if (int.TryParse(input, out num))
            {
                sum += num;
                Console.WriteLine($"Adding {num} to {sum - num} = {sum}");
            }
            else
            {
                message += input;
                Console.WriteLine($"Current Message is: {message}");
            }
        }
    }
}
