using HomeWorkInterface.Intefaces;

namespace HomeWorkInterface
{
    class Calculator : ICalculator
    {
        ILogger _logger;
        /// <summary>
        /// Конструктор с параметрами,
        /// </summary>
        /// <param name="logger">Экземпляр класса логгер</param>
        
        public Calculator(ILogger logger)
        {
            _logger = logger;
        }
        int number1, number2;
        public string[] StringArray { get; private set; } = null;

        /// <summary>
        /// Старт калькулятора
        /// </summary>
        /// <param name="numbers"></param>

        public void Start(string numbers)
        {
            while (true)
                try
                {
                    StringArray = numbers.Split(" ");
                    number1 = Int32.Parse(StringArray[0]);
                    number2 = Int32.Parse(StringArray[2]);
                    _logger.Event("Parse");
                    break;
                }
                catch (Exception ex)
                {
                    _logger.Error($"Error,{ex.Message}, if need help write /help");
                    return;
                }
            switch (StringArray[1])
            {
                case "+":
                    Console.WriteLine(Sum(number1, number2));
                    break;
                default:
                    Console.WriteLine("Empty operator");
                    break;
            }

        }

        /// <summary>
        /// Метод суммы 2х чисел!
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>Возвращает целочисленное значение!</returns>
 
        public int Sum(int number1, int number2)
        {
            checked
            {
                return number1 + number2;
            }
        }
    }
}
