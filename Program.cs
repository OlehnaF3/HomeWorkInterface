namespace HomeWorkInterface
{
    class Program
    {
        public static void Main()
        {
            Calculator calc = new Calculator(new Logger());
            while (true)
            {
                string str = Console.ReadLine();
                if (str == "/exit") break;
                else if (str == "/help")
                {
                    Console.WriteLine("Example of how to write \"5\" \"+\" \"5\"");
                    continue;
                }
                calc.Start(str);
            }

        }
    }

}
