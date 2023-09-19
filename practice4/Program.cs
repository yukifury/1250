using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;
using System.Diagnostics.Eventing.Reader;
using System.Threading;

namespace practice4
{
    internal class Program
    {
        static public int PriceX = 0;
        static public Cake cake = new Cake();
        

        static void Main()
        {
            int end = 0;
            int pos = 2;
           
            Menu();
            Price();
            Descr();
            Console.SetCursorPosition(0, pos);
            Console.WriteLine(">");
            
            
            while (end != 1)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.DownArrow & pos != 8)
                {
                    Console.Clear();
                    Menu();
                    Price();
                    Descr();
                    pos++;
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine(">");
                }
                else if (key.Key == ConsoleKey.UpArrow & pos != 2)
                {
                    Console.Clear();
                    Menu();
                    Price();
                    Descr();
                    pos--;
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine(">");
                }
                else if (key.Key == ConsoleKey.Enter & pos == 2)
                {
                    SizeCake();
                }
                else if (key.Key == ConsoleKey.Enter & pos == 8)
                {
                    End();
                }
                else if (key.Key == ConsoleKey.Enter & pos == 3)
                {
                    cakeTrueSize();
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Menu();
                    Price();
                    Descr();
                    pos = 2;
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine(">");
                }
                else if (key.Key == ConsoleKey.DownArrow & pos == 8)
                {
                    Console.Clear();
                    Menu();
                    Price();
                    Descr();
                    pos = 2;
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine(">");
                }
                else if (key.Key == ConsoleKey.UpArrow & pos == 2)
                {
                    Console.Clear();
                    Menu();
                    Price();
                    Descr();
                    pos = 8;
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine(">");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ошибка! Кажется, вы не туда нажали..");
                    Thread.Sleep(1000);
                }

            }
           




        }
        static void Menu()
        {
            Console.WriteLine("Пекарня *У Ахмета*\nУкажите желаемые параметры торта и совершите заказ");
            Console.WriteLine("  Форма торта");
            Console.WriteLine("  Размер торта");
            Console.WriteLine("  Вкус коржей");
            Console.WriteLine("  Количество коржей");
            Console.WriteLine("  Глазурь");
            Console.WriteLine("  Декор");
            Console.WriteLine("  Конец заказа");
        }
        static void Descr()
        {
            Console.WriteLine("Описание торта:");
            Console.WriteLine($"Форма: {cake.Form}");
            Console.WriteLine($"Размер: {cake.Size}");
            Console.WriteLine($"Вкус: {cake.Flavour}");
            Console.WriteLine($"Количество коржей: {cake.CountKorzh}");
            Console.WriteLine($"Декор: {cake.Decor}");
    }
        static void Price()
        {
            int x = PriceX;
            Console.WriteLine($"\n\nОбщая стоимость: {x}$");
        }
        static void SizeCake()
        {
            int pos = 1;
            int end = 0;
            int price = 0;
            Console.Clear();
            Console.WriteLine("Выберите форму торта:");
            Console.WriteLine("  Круглый (5$)");
            Console.WriteLine("  Квадратный (7$)");
            Console.WriteLine("  Сердечко (10$)");
            Console.SetCursorPosition(0, pos);
            Console.WriteLine(">");
            while (end != 1)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.DownArrow & pos != 3)
                {
                    Console.Clear();
                    pos++;
                    Console.WriteLine("Выберите форму торта:");
                    Console.WriteLine("  Круглый (5$)");
                    Console.WriteLine("  Квадратный (7$)");
                    Console.WriteLine("  Сердечко (10$)");
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine(">");
                }
                if (key.Key == ConsoleKey.UpArrow & pos != 1)
                {
                    Console.Clear();
                    pos--;
                    Console.WriteLine("Выберите форму торта:");
                    Console.WriteLine("  Круглый (5$)");
                    Console.WriteLine("  Квадратный (7$)");
                    Console.WriteLine("  Сердечко (10$)");
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine(">");
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    end = 1;
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.Enter & pos == 1)
                {
                    price = 5;
                    PriceX = PriceX + price;
                    cake.Form = "Круглый";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово! Для выхода нажмите Escape.");
                }
                if (key.Key == ConsoleKey.Enter & pos == 2)
                {
                    price = 7;
                    PriceX = PriceX + price;
                    cake.Form = "Квадратный";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово! Для выхода нажмите Escape.");
                }
                if (key.Key == ConsoleKey.Enter & pos == 3)
                {
                    price = 10;
                    PriceX = PriceX + price;
                    cake.Form = "Сердечко";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово! Для выхода нажмите Escape.");
                }
            }
        }
        static void cakeTrueSize()
        {
            int pos = 1;
            int end = 0;
            int price = 0;
            Console.Clear();
            Console.WriteLine("Выберите размер торта:");
            Console.WriteLine("  Маленький | 10см. (10$)");
            Console.WriteLine("  Средний | 20см. (20$)");
            Console.WriteLine("  Большой | 35см. (35$)");
            Console.WriteLine($"  Гигантский | 50см. (СКИДКА! ВСЕГО ЗА 45$)");
            Console.SetCursorPosition(0, pos);
            Console.WriteLine(">");
            while (end != 1)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.DownArrow & pos != 4)
                {
                    Console.Clear();
                    pos++;
                    Console.WriteLine("Выберите размер торта:");
                    Console.WriteLine("  Маленький | 10см. (10$)");
                    Console.WriteLine("  Средний | 20см. (20$)");
                    Console.WriteLine("  Большой | 35см. (35$)");
                    Console.WriteLine($"  Гигантский | 50см. (СКИДКА! ВСЕГО ЗА 45$)");
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine(">");
                }
                if (key.Key == ConsoleKey.UpArrow & pos != 1)
                {
                    Console.Clear();
                    pos--;
                    Console.WriteLine("Выберите размер торта:");
                    Console.WriteLine("  Маленький | 10см. (10$)");
                    Console.WriteLine("  Средний | 20см. (20$)");
                    Console.WriteLine("  Большой | 35см. (35$)");
                    Console.WriteLine($"  Гигантский | 50см. (СКИДКА! ВСЕГО ЗА 45$)");
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine(">");
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    end = 1;
                    Console.Clear();
                }
                if (key.Key == ConsoleKey.Enter & pos == 1)
                {
                    price = 10;
                    PriceX = PriceX + price;
                    cake.Size = "Маленький";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово! Для выхода нажмите Escape.");
                }
                if (key.Key == ConsoleKey.Enter & pos == 2)
                {
                    price = 20;
                    PriceX = PriceX + price;
                    cake.Size = "Средний";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово! Для выхода нажмите Escape.");
                }
                if (key.Key == ConsoleKey.Enter & pos == 3)
                {
                    price = 35;
                    PriceX = PriceX + price;
                    cake.Size = "Большой";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово! Для выхода нажмите Escape.");
                }
                if (key.Key == ConsoleKey.Enter & pos == 4)
                {
                    price = 45;
                    PriceX = PriceX + price;
                    cake.Size = "Гигантский";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово! Для выхода нажмите Escape.");
                }
            }
        }
        static void End()
        {
            Console.Clear();
            if (cake.Form == null || cake.Size == null || cake.Flavour == null || cake.CountKorzh == null || cake.Glazur == null || cake.Decor == null)
            {
                Console.WriteLine("Вы не указали параметры торта. ");
                Thread.Sleep(500);
                Console.WriteLine("Нажмите Escape для возвращения");
            }
            else
            {
                DateTime date = DateTime.Now;
                string End = $"\n {date}\n  ЗАКАЗ НА {PriceX}$\nФорма: {cake.Form} \nРазмер: {cake.Size}\n Вкус: {cake.Flavour} \nКоличество коржей: {cake.CountKorzh} \nГлазурь: {cake.Glazur} \nДекорации: {cake.Decor}\n";
                File.AppendAllText("S:\\prog\\bot\\practice4\\history.txt", End);
                Console.WriteLine("Заказ отправлен! Нажмите Escape для оформление второго заказа");
            }

        }

    }




    internal class Cake
    {
        public string Form;
        public string Size;
        public string Flavour;
        public string CountKorzh;
        public string Glazur;
        public string Decor;
    }
}
