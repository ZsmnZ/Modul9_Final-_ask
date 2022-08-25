using System;
namespace ExceptionPractic
{
    class Task1
    {
        static void Main(string[] args)
        {
            List<Exception> excptions = new List<Exception>
            {
                new FormatException("Недопустимый формат"),
                new FileNotFoundException("Файл не существует"),
                new TimeoutException("Время истекло"),
                new DirectoryNotFoundException("Неверный путь к каталогу"),
                new MyException("Недопустимый возраст")
            };
            foreach (Exception e in excptions)
            {
                try
                {
                    throw e;
                }
                catch (MyException exc)
                {
                    Console.WriteLine($"{exc.Message}");
                }
                catch (Exception exc)
                {
                    Console.WriteLine($"{exc.Message}");
                }
            }
        }
        public class MyException : Exception
        {
            public MyException(string message) : base(message) { }
        }
    }
}