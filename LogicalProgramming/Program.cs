namespace LogicalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 1;
            int n3, i, number;
            Console.Write("Enter the how many number of fibonacci units to print: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.Write(n1 + " " + n2 + " ");
            for (i = 2; i < number; ++i)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}