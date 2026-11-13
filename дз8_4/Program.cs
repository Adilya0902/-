using System;

namespace Task8_4
{
    class Program
    {
        public static void CheckIFormattable(object obj)
        {
            if (obj is IFormattable)
            {
                Console.WriteLine($"Объект типа {obj.GetType().Name} РЕАЛИЗУЕТ интерфейс IFormattable.");
                IFormattable formattableObj = obj as IFormattable;
                if (formattableObj != null)
                {
                    string formattedString = formattableObj.ToString("G", null);
                    Console.WriteLine($"   Отформатированное значение: {formattedString}");
                }
            }
            else
            {
                Console.WriteLine($"Объект типа {obj.GetType().Name} НЕ реализует интерфейс IFormattable.");
            }
            Console.WriteLine("-------------------------------------------------");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== Тест Задания 8.4 ===");
            int number = 12345;           
            double pi = 3.14159;        
            DateTime date = DateTime.Now; 
            string text = "Привет";    
            CheckIFormattable(number);
            CheckIFormattable(pi);
            CheckIFormattable(date);
            CheckIFormattable(text);
            Console.ReadKey(); 
        }
    }
}