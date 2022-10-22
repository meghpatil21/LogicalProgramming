namespace LogicalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i;
            int isPrime = 1;

            for (i = 2; i <= n / 2; i++)  
            {
                if (n % i == 0)
                {
                    isPrime = 0;
                    Console.WriteLine("Number is Not Prime");
                    break;
                }

            }


            if (isPrime == 1)

            {
                Console.WriteLine("Number is Prime");
            }

        }
    }
}