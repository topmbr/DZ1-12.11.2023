using System;
using System.Threading;
using System.Threading.Tasks;
namespace ConsoleApp88
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Створюємо об'єкт класу Task за допомогою методу Start
            Task task1 = new Task(() => DisplayDateTime("Task.Start"));
            task1.Start();

            // Створюємо завдання за допомогою методу Task.Factory.StartNew
            Task task2 = Task.Factory.StartNew(() => DisplayDateTime("Task.Factory.StartNew"));

            // Створюємо завдання за допомогою методу Task.Run
            Task task3 = Task.Run(() => DisplayDateTime("Task.Run"));

            // Очікуємо завершення всіх завдань
            Task.WaitAll(task1, task2, task3);

            Console.ReadLine();
        }

        static void DisplayDateTime(string taskName)
        {
            for (int i = 0; i < 5; i++)
            {
                // Виводимо поточний час і дату разом з ім'ям завдання
                Console.WriteLine($"{taskName}: {DateTime.Now}");

                // Затримка на 1 секунду
                Thread.Sleep(1000);
            }
        }
    }
}
