using System;
namespace Task
{
    class Task2
    {
        static void Main(string[] args)
        {
            NumberReader numberReader = new NumberReader();
            numberReader.EnterNumberEvent += ShowNumber;
            while (true)
            {
                try
                {
                    numberReader.Read();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введено некоректное значение");
                }
            }
        }
        static void ShowNumber(int number)
        {
            List<string> names = new List<string>
            {
                "Аганесян",
                "Бобков",
                "Лунёв",
                "Яковлев",
                "Зотов"
            };
            switch (number)
            {
                case 1:
                    names.Sort();
                    names.ForEach(Console.WriteLine);
                    break;
                case 2:
                    names.Sort();
                    names.Reverse();
                    names.ForEach(Console.WriteLine);
                    break;
            }
        }
    }
    public class NumberReader
    {
        public delegate void EnterNumberDelegate(int number);
        public event EnterNumberDelegate EnterNumberEvent;
        public void Read()
        {
            Console.WriteLine();
            Console.WriteLine("Введите число 1 или 2");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number != 1 && number != 2) throw new FormatException();
            NumberEntered(number);
        }
        protected virtual void NumberEntered(int number)
        {
            EnterNumberEvent?.Invoke(number);
        }
    }
}

