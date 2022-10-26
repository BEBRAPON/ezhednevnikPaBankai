using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshednevnik
{
    internal class Program
    {
        static DateTime date = DateTime.Now;
        static void Main()
        {
            ConsoleKeyInfo clavisha = Console.ReadKey();
            string date1 = date.ToShortDateString();
            int pos = 2;
            Strelki(pos, date1, clavisha);
        }
        static void Strelki( int pos, string date1, ConsoleKeyInfo clavisha)
        {
            clavisha = Console.ReadKey();
            while (clavisha.Key != ConsoleKey.Escape)
            {
                if (clavisha.Key == ConsoleKey.UpArrow)
                {
                    pos--;
                    if (pos <= 1)
                    {
                        pos = 2;
                        Console.SetCursorPosition(0,pos);
                    }

                }
                else if (clavisha.Key == ConsoleKey.DownArrow)
                {
                    pos++;
                }
                Console.Clear();
                Console.WriteLine(date1);
                Console.WriteLine("-----------------------");
                Perecl(pos, date1, clavisha);
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
                clavisha = Console.ReadKey();
                if (clavisha.Key == ConsoleKey.LeftArrow || clavisha.Key == ConsoleKey.RightArrow)
                {
                    Data(date1, pos,clavisha);
                }    
            }
            Console.Clear();
            Environment.Exit(0);
        }
        static void Data(string date1, int pos, ConsoleKeyInfo clavisha)
        {
            clavisha = Console.ReadKey();
            if (clavisha.Key == ConsoleKey.LeftArrow)
            {
                date = date.AddDays(-1);
                date1 = date.ToShortDateString();
                Main();
            }
            if (clavisha.Key == ConsoleKey.RightArrow)
            {
                date = date.AddDays(1);
                date1 = date.ToShortDateString();
                Main();
            }
        }
        static void firstZam(string date1, int pos, ConsoleKeyInfo clavisha)
        {
            List<string> zam = new List<string>();
            zam.Add("  1.Сдать ИГЭ па банкай.");
            zam.Add("  2.Слиться с хогьеку.");
            foreach (string item in zam)
                Console.WriteLine(item);
            if (pos == 2 && clavisha.Key == ConsoleKey.Enter)
            {
                firstOpisFirstZam(pos, date1);
            }
            else if (pos == 3 && clavisha.Key == ConsoleKey.Enter)
            {
                secondOpisFirstZam(pos, date1);
            }
            else if (clavisha.Key == ConsoleKey.Backspace)
            {
                Main();
            }
            
        }
        static void firstOpisFirstZam(int pos, string date1)
        {
            Console.Clear();
            List<string> opis = new List<string>();
            opis.Add("Сдать ИГЭ па банкай.");
            opis.Add("--------------------------");
            opis.Add("Описание: Сдать ИГЭ па банкай на 100 баллов.");
            opis.Add("Дата: 27.10.2022\r\nВремя: в 12:12.");
            foreach (string item in opis)
                Console.WriteLine(item);
        }
        static void secondOpisFirstZam(int pos, string date1)
        {
            Console.Clear();
            List<string> opis = new List<string>();
            opis.Add("Слиться с хогьеку.");
            opis.Add("--------------------------");
            opis.Add("Описание: слиться с хогьеку, чтобы стать бессмертной бабочкой.");
            opis.Add("Дата: 27.10.2022.\r\nВремя: 16:33");
            foreach (string item in opis)
                Console.WriteLine(item);
        }
        static void secondZam(string date1, int pos, ConsoleKeyInfo clavisha)
        {
            List<string> zam = new List<string>();
            zam.Add("  1.Построить замок в Лас Ночес.");
            zam.Add("  2.Сдать ИГЭ па созданию эспады.");
            foreach (string item in zam)
                Console.WriteLine(item);
            if (pos == 2 && clavisha.Key == ConsoleKey.Enter)
            {
                firstOpisSecondZam(pos, date1);
            }
            else if (pos == 3 && clavisha.Key == ConsoleKey.Enter)
            {
                secondOpisSecondZam(pos, date1);
            }
        }
        static void firstOpisSecondZam(int pos, string date1)
        {
            Console.Clear();
            List<string> opis = new List<string>();
            opis.Add("Построить замок в Лас Ночес.");
            opis.Add("--------------------------");
            opis.Add("Описание: Посторить замок в Лас Ночес для проживания в Уэкомунде с аранкарами.");
            opis.Add("Дата: 30.10.2022.\r\nВремя: 15:15");
            foreach (string item in opis)
                Console.WriteLine(item);
        }
        static void secondOpisSecondZam(int pos, string date1)
        {
            Console.Clear();
            List<string> opis = new List<string>();
            opis.Add("Сдать ИГЭ па созданию эспады.");
            opis.Add("--------------------------");
            opis.Add("Описание: Сдать ИГЭ па эспада и создать 10 аранкаров для захвата на 100 баллов.");
            opis.Add("Дата: 30.10.2022.\r\nВремя: в 19:19.");
            foreach (string item in opis)
                Console.WriteLine(item);
        }
        static void thirdZam(string date1, int pos, ConsoleKeyInfo clavisha)
        {
            List<string> zam = new List<string>();
            zam.Add("  1.Создать план.");
            zam.Add("  2.Попасть в мукен.");
            foreach (string item in zam)
                Console.WriteLine(item);
            if (pos == 2 && clavisha.Key == ConsoleKey.Enter)
            {
                firstOpisThirdZam(pos, date1);
            }
            else if (pos == 3 && clavisha.Key == ConsoleKey.Enter)
            {
                secondOpisThirdZam(pos, date1);
            }
        }
        static void firstOpisThirdZam(int pos, string date1)
        {
            Console.Clear();
            List<string> opis = new List<string>();
            opis.Add("Создать план.");
            opis.Add("--------------------------");
            opis.Add("Описание: Создать план и продумать его на 100 лет вперёд.");
            opis.Add("Дата: 01.11.2022.\r\nВремя: в 10:10.");
            foreach (string item in opis)
                Console.WriteLine(item);
        }
        static void secondOpisThirdZam(int pos, string date1)
        {
            Console.Clear();
            List<string> opis = new List<string>();
            opis.Add("Попасть в мукен.");
            opis.Add("--------------------------");
            opis.Add("Описание: Попасть в мукен для реализации плана(чтобы стать сильней).");
            opis.Add("Дата: 01.11.2022.\r\nВремя: в 15:10.");
            foreach (string item in opis)
                Console.WriteLine(item);
        }
        static void fourthZam(string date1, int pos, ConsoleKeyInfo clavisha)
        {
            List<string> zam = new List<string>();
            zam.Add("  1.Пойти в больницу.");
            zam.Add("  2.Тест.");
            foreach (string item in zam)
                Console.WriteLine(item);
            if (pos == 2 && clavisha.Key == ConsoleKey.Enter)
            {
                firstOpisFourthZam(pos, date1);
            }
            else if (pos == 3 && clavisha.Key == ConsoleKey.Enter)
            {
                secondOpisFourthZam(pos, date1);
            }
        }
        static void firstOpisFourthZam(int pos, string date1)
        {
            Console.Clear();
            List<string> opis = new List<string>();
            opis.Add("Пойти в больницу.");
            opis.Add("--------------------------");
            opis.Add("Описание: Пойти в больницу, чтобы в очередной раз узнать, что твоё зрение минус 10000000000.");
            opis.Add("Дата: 09.11.2022.\r\nВремя: в 10:58.");
            foreach (string item in opis)
                Console.WriteLine(item);
        }
        static void secondOpisFourthZam(int pos, string date1)
        {
            Console.Clear();
            List<string> opis = new List<string>();
            opis.Add("Тест.");
            opis.Add("--------------------------");
            opis.Add("Описание: Подготовиться к тесту.");
            opis.Add("Дата: 09.11.2022.\r\nВремя: в 19:10.");
            foreach (string item in opis)
                Console.WriteLine(item);
        }
        static void fifthZam(string date1, int pos, ConsoleKeyInfo clavisha)
        {
            List<string> zam = new List<string>();
            zam.Add("  1.Посмотреть аниме.");
            zam.Add("  2.Грустить после просмотра аниме.");
            foreach (string item in zam)
                Console.WriteLine(item);
            if (pos == 2 && clavisha.Key == ConsoleKey.Enter)
            {
                firstOpisFifthZam(pos, date1);
            }
            else if (pos == 3 && clavisha.Key == ConsoleKey.Enter)
            {
                secondOpisFifthZam(pos, date1);
            }
        }
        static void firstOpisFifthZam(int pos, string date1)
        {
            Console.Clear();
            List<string> opis = new List<string>();
            opis.Add("Посмотреть аниме.");
            opis.Add("--------------------------");
            opis.Add("Описание: Посмотреть короткое аниме, чтобы убить время.");
            opis.Add("Дата: 10.11.2022.\r\nВремя: в 10:00.");
            foreach (string item in opis)
                Console.WriteLine(item);
        }
        static void secondOpisFifthZam(int pos, string date1)
        {
            Console.Clear();
            List<string> opis = new List<string>();
            opis.Add("Грустить после просмотра аниме.");
            opis.Add("--------------------------");
            opis.Add("Описание: Грустить после просмотра аниме, так как понравился сюжет, а об продолжении ничего не известно.");
            opis.Add("Дата: 10.11.2022.\r\nВремя: в 23:13.");
            foreach (string item in opis)
                Console.WriteLine(item);
        }

        static void Perecl(int pos, string date1, ConsoleKeyInfo clavisha)
        {
            if (date1 == "27.10.2022")
            {
                firstZam(date1, pos, clavisha);
            }
            else if (date1 == "30.10.2022")
            {
                secondZam(date1, pos, clavisha);
               
            }
            else if (date1 == "01.11.2022")
            {
                thirdZam(date1, pos, clavisha);
            }
            else if (date1 == "09.11.2022")
            {
                fourthZam(date1, pos, clavisha);
            }
            else if (date1 == "10.11.2022")
            {
                fifthZam(date1, pos, clavisha);
            }
            Data(date1, pos, clavisha);
        }
    }
}