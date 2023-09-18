namespace Method_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for a joke");
            int num = Convert.ToInt32(Console.ReadLine());
            Joke(num);
        }

        public static void Joke()
        {
            Console.WriteLine("99 little bugs left in the code");
            Thread.Sleep(1000);
            Console.WriteLine("99 little bugs left");
            Thread.Sleep(1000);
            Console.WriteLine("Fix a bug, run it again");
            Thread.Sleep(1000);
            Console.WriteLine("100 little bugs left in the code");
        }

        public static void Joke(int numBugs)
        {
            Console.WriteLine($"{numBugs} little bugs left in the code");
            Thread.Sleep(1000);
            Console.WriteLine($"{numBugs} little bugs left");
            Thread.Sleep(1000);
            Console.WriteLine($"Fix a bug, run it again");
            Thread.Sleep(1000);
            Console.WriteLine($"{++numBugs} little bugs left in the code");
        }

    }
}