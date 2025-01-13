using HomeWorkInterface.Intefaces;
namespace HomeWorkInterface
{
    public class Logger : ILogger
    {
        /// <summary>
        /// Метод ошибки!
        /// </summary>
        /// <param name="message"></param>
 
        public void Error(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();

        }
        /// <summary>
        /// Метод события!
        /// </summary>
        /// <param name="message"></param>

        public void Event(string message)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();

        }
    }
}
