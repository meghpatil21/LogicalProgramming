namespace LogicalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;
            int n;
            Console.Write("Enter the Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            n = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine($"\n {number} is a perfect number");
                
            }
            else
            {
                Console.WriteLine($"\n {number} is not a perfect number");
                
            }

        }
    }
}