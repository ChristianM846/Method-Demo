namespace Method_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;

            Console.WriteLine("Enter a number for a joke");
            int num = Convert.ToInt32(Console.ReadLine());
            Joke(num);
            Thread.Sleep(3000);




            Console.WriteLine("You wanna here a knock knock joke? (Yes/No)");
            answer = Console.ReadLine().Trim().ToUpper();
            while (answer != "YES" & answer != "NO")
            {
                Console.WriteLine("That is not a valid response. Yes or No?");
                answer = Console.ReadLine().Trim().ToUpper();
            }

            if (answer == "YES")
            {
                Console.WriteLine("Great! Here it is:");
                Console.WriteLine();
                KnockJoke();
            }
            else if (answer == "NO")
            {
                Console.WriteLine("Well that's too bad, you getting one anyway >:)");
                Console.WriteLine();
                KnockJoke();
            }
        }

        public static void Joke()
        {
            Console.WriteLine("99 little bugs left in the code");
            Console.ReadLine();
            Console.WriteLine("99 little bugs left");
            Console.ReadLine();
            Console.WriteLine("Fix a bug, run it again");
            Console.ReadLine();
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

        public static void DrawPikachu()
        {
            Console.WriteLine("       \\:.             .:/     .");
            Console.WriteLine("        \\``._________.''/      .");
            Console.WriteLine("         \\             /       .");
            Console.WriteLine(" .--.--, / .':.   .':. \\       .");
            Console.WriteLine("/__:  /  | '::' . '::' |       .");
            Console.WriteLine("   / /   |`.   ._.   .'|       .");
            Console.WriteLine("  / /    |.'         '.|       .");
            Console.WriteLine(" /___-_-,|.\\  \\   /  /.|       .");
            Console.WriteLine("      // |''\\.;   ;,/ '|       .");
            Console.WriteLine("      `==|:=         =:|       .");
            Console.WriteLine("         `.          .'        .");
            Console.WriteLine("           :-._____.-:         .");
            Console.WriteLine("          `''       `''        .");
        }

        public static void KnockJoke()
        {
            Console.WriteLine("Bitch");
        }

    }
}