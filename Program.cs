using System;

namespace ConditionalOperatorsHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int repetitionsCount;
            string message;

            Console.WriteLine("Введите текст:");
            message = Console.ReadLine();
            Console.WriteLine("Сколько раз повторить вывод сообщения?");
            repetitionsCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < repetitionsCount; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}
