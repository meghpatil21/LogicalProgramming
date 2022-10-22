using System.Diagnostics;

namespace LogicalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Enter to start Stopwatch");
            Console.ReadLine();
            stopwatch.Start();

            Console.WriteLine("Enter to stop Stopwatch");
            Console.ReadLine();
            stopwatch.Stop();

            Console.WriteLine("Time Elapsed : {0}", stopwatch.Elapsed);
        }
    }
}