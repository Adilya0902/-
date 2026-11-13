
using System;
using System.IO;

namespace дз8_3 
{
    class Program
    {
        public static void ProcessFile()
        {
            Console.WriteLine("\nВведите имя файла (например, test.txt):");
            string fileName = Console.ReadLine();

            if (!File.Exists(fileName))
            {
                Console.WriteLine("Такого файла не существует! Программа завершает работу.");
                return;
            }
            try
            {
                string content = File.ReadAllText(fileName);
                string upperContent = content.ToUpper();
                string outputFileName = "OUTPUT_" + fileName;
                File.WriteAllText(outputFileName, upperContent);
                Console.WriteLine($"Готово! Создан файл: {outputFileName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
        static void Main(string[] args)
        {
            ProcessFile();
            Console.ReadKey();
        }
    }
}
