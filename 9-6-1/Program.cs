using System.Reflection;

namespace _9_6_1
{
    

    // 1. Создаем свой тип исключения
    public class MyCustomException : Exception
    {
        public MyCustomException(string message) : base(message) { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 2. Создаем массив исключений (5 видов, включая собственное)
            Exception[] exceptions = new Exception[]
            {
            new DivideByZeroException("Деление на ноль."),
            new NullReferenceException("Попытка обратиться к null объекту."),
            new IndexOutOfRangeException("Выход за пределы массива."),
            new InvalidOperationException("Недопустимая операция."),
            new MyCustomException("Мое собственное исключение.")
            };

            // 3. Итерация по массиву исключений
            foreach (var ex in exceptions)
            {
                try
                {
                    throw ex; // намеренно выбрасываем исключение
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Поймано исключение: {e.Message}");
                }
                finally
                {
                    Console.WriteLine("Блок finally выполнен.\n");
                }
            }

            Console.WriteLine("Работа программы завершена.");
        }
    }
}
