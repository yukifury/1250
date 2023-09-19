using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;
using System.Diagnostics.Eventing.Reader;
using System.Threading;
using static practice4.Program;

namespace practice4
{
    internal class Program
    {
        static public int PriceX = 0;
        static public Cake cake = new Cake();
        static public int end = 0;


        static void Main()
        {
            int pos = 2;
            while (end != 1)
            {

                Menu();
                Price();
                Descr();
                Console.SetCursorPosition(0, pos);
                Console.WriteLine(">");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                if (key.Key == ConsoleKey.DownArrow & pos != 8)
                {

                    pos++;

                }
                else if (key.Key == ConsoleKey.UpArrow & pos != 2)
                {

                    pos--;

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
                else if (key.Key == ConsoleKey.Enter & pos == 4)
                {
                    CakeFlavour();
                }
                else if (key.Key == ConsoleKey.Enter & pos == 5)
                {
                    CakeCountCorzh();
                }
                else if (key.Key == ConsoleKey.Enter & pos == 6)
                {
                    CakeGlazur();
                }
                else if (key.Key == ConsoleKey.Enter & pos == 7)
                {
                    CakeDecor();
                }    
                else if (key.Key == ConsoleKey.Escape)
                {

                    pos = 2;

                }
                else if (key.Key == ConsoleKey.DownArrow & pos == 8)
                {

                    pos = 2;

                }
                else if (key.Key == ConsoleKey.UpArrow & pos == 2)
                {

                    pos = 8;

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ошибка! Кажется, вы не туда нажали..");
                    Thread.Sleep(1000);
                    Console.Clear();
                }

            }





        }
        static void Menu()
        {
            Console.WriteLine("   Пекарня *У Ахмета*\nУкажите желаемые параметры торта и совершите заказ");
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
            Console.WriteLine("-------------------------"); 
            Console.WriteLine("Описание торта:");
            Console.WriteLine($" Форма: {cake.Form}.");
            Console.WriteLine($" Размер: {cake.Size}.");
            Console.WriteLine($" Вкус: {cake.Flavour}.");
            Console.WriteLine($" Количество коржей: {cake.CountKorzh}.");
            Console.WriteLine($" Глазурь: {cake.Glazur}.");
            Console.WriteLine($" Декор: {cake.Decor}.");
        }
        static void Price()
        {
            int x = PriceX;
            Console.WriteLine("\n-------------------------");
            Console.WriteLine($"Общая стоимость: {x}$");
        }
        static void SizeCake()
        {
            int pos = 1;
            int end = 0;
            int price = 0;
            Console.Clear();

            while (end != 1)
            {
                Console.WriteLine("Выберите форму торта:");
                Console.WriteLine("  Круглый (5$)");
                Console.WriteLine("  Квадратный (7$)");
                Console.WriteLine("  Сердечко (10$)");
                Console.SetCursorPosition(0, pos);
                Console.WriteLine(">");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                if (key.Key == ConsoleKey.DownArrow & pos != 3)
                {

                    pos++;

                }
                else if (key.Key == ConsoleKey.UpArrow & pos != 1)
                {

                    pos--;

                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    end = 1;
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.DownArrow & pos == 3)
                {
                    pos = 1;
                }
                else if (key.Key == ConsoleKey.UpArrow & pos == 1)
                {
                    pos = 3;
                }
                else if (key.Key == ConsoleKey.Enter & pos == 1)
                {
                    price = 5;
                    PriceX = PriceX + price;
                    cake.Form = "Круглый";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово!");
                    Thread.Sleep(700);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.Enter & pos == 2)
                {
                    price = 7;
                    PriceX = PriceX + price;
                    cake.Form = "Квадратный";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово!");
                    Thread.Sleep(700);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.Enter & pos == 3)
                {
                    price = 10;
                    PriceX = PriceX + price;
                    cake.Form = "Сердечко";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово!");
                    Thread.Sleep(700);
                    Console.Clear();
                }
            }
        }
        static void cakeTrueSize()
        {
            int pos = 1;
            int end = 0;
            int price = 0;
            Console.Clear();

            while (end != 1)
            {
                Console.WriteLine("Выберите размер торта:");
                Console.WriteLine("  Маленький | 10см. (10$)");
                Console.WriteLine("  Средний | 20см. (20$)");
                Console.WriteLine("  Большой | 35см. (35$)");
                Console.WriteLine($"  Гигантский | 50см. (СКИДКА! ВСЕГО ЗА 45$)");
                Console.SetCursorPosition(0, pos);
                Console.WriteLine(">");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                if (key.Key == ConsoleKey.DownArrow & pos != 4)
                {

                    pos++;

                }
                else if (key.Key == ConsoleKey.UpArrow & pos != 1)
                {

                    pos--;

                }
                else if (key.Key == ConsoleKey.DownArrow & pos == 4)
                {
                    pos = 1;
                }
                else if (key.Key == ConsoleKey.UpArrow & pos == 1)
                {
                    pos = 4;
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    end = 1;
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.Enter & pos == 1)
                {
                    price = 10;
                    PriceX = PriceX + price;
                    cake.Size = "Маленький";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово!");
                    Thread.Sleep(700);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.Enter & pos == 2)
                {
                    price = 20;
                    PriceX = PriceX + price;
                    cake.Size = "Средний";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово!");
                    Thread.Sleep(700);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.Enter & pos == 3)
                {
                    price = 35;
                    PriceX = PriceX + price;
                    cake.Size = "Большой";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово!");
                    Thread.Sleep(700);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.Enter & pos == 4)
                {
                    price = 45;
                    PriceX = PriceX + price;
                    cake.Size = "Гигантский";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово!");
                    Thread.Sleep(700);
                    Console.Clear();
                }
            }
        }
        static void CakeFlavour()
        {
            int pos = 1;
            int end = 0;
            int price = 0;
            Console.Clear();

            while (end != 1)
            {
                Console.WriteLine("Выберите начинку для торта:");
                Console.WriteLine($"  Классическая | 0$");
                Console.WriteLine("  Ванильная (10$)");
                Console.WriteLine($"  Клубничное (10$)");
                Console.WriteLine("  Вишневая (10$)");
                Console.WriteLine("  Ягодное асорти (15$)");
                Console.WriteLine($"  Банановое (15$");
                Console.SetCursorPosition(0, pos);
                Console.WriteLine(">");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                if (key.Key == ConsoleKey.DownArrow & pos != 6)
                {

                    pos++;
                }
                else if (key.Key == ConsoleKey.DownArrow & pos == 6)
                {

                    pos = 1;
                }
                else if (key.Key == ConsoleKey.UpArrow & pos == 1)
                {
                    pos = 6;
                }
                else if (key.Key == ConsoleKey.UpArrow & pos != 1)
                {

                    pos--;

                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    end = 1;
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.Enter & pos == 1)
                {
                    cake.Flavour = "Классический";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово!");
                    Thread.Sleep(700);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.Enter & pos == 2)
                {
                    price = 10;
                    PriceX = PriceX + price;
                    cake.Flavour = "Ванильный";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово!");
                    Thread.Sleep(700);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.Enter & pos == 3)
                {
                    price = 10;
                    PriceX = PriceX + price;
                    cake.Flavour = "Клубничный";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово!");
                    Thread.Sleep(700);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.Enter & pos == 4)
                {
                    price = 10;
                    PriceX = PriceX + price;
                    cake.Flavour = "Вишневый";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово!");
                    Thread.Sleep(700);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.Enter & pos == 5)
                {
                    price = 15;
                    PriceX = PriceX + price;
                    cake.Flavour = "Ягодное асорти";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово!");
                    Thread.Sleep(700);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.Enter & pos == 6)
                {
                    price = 15;
                    PriceX = PriceX + price;
                    cake.Flavour = "Банановый";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово!");
                    Thread.Sleep(700);
                    Console.Clear();
                }
            }
        }
        static void End()
        {
            Console.Clear();
            if (cake.Form == null || cake.Size == null || cake.Flavour == null || cake.CountKorzh == null || cake.Glazur == null || cake.Decor == null)
            {
                Console.WriteLine("Вы не указали параметры торта. ");
                Thread.Sleep(1000);
                Console.Clear();
            }
            else
            {
                DateTime date = DateTime.Now;
                string End = $"\n {date}\n  ЗАКАЗ НА {PriceX}$\nФорма: {cake.Form} \nРазмер: {cake.Size}\nВкус: {cake.Flavour} \nКоличество коржей: {cake.CountKorzh} \nГлазурь: {cake.Glazur} \nДекорации: {cake.Decor}\n";
                File.AppendAllText("S:\\prog\\bot\\practice4\\history.txt", End);
                Console.WriteLine("Заказ отправлен! Нажмите Escape для оформление второго заказа\nИли любую другую клавишу для выхода..");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    cake.Form = null;
                    cake.Size = null;
                    cake.Flavour = null;
                    cake.CountKorzh = null;
                    cake.Glazur = null;
                    cake.Decor = null;
                }
                else
                {
                    end++;
                    return;
                }
            }

        }
        static void CakeCountCorzh()
        {
            int pos = 1;
            int end = 0;
            int price = 0;
            Console.Clear();

            while (end != 1)
            {
                Console.WriteLine("Выберите количество коржей:");
                Console.WriteLine($"  Один корж (5$)");
                Console.WriteLine("  Два коржа (10$)");
                Console.WriteLine($"  Три коржа (15$)");
                Console.SetCursorPosition(0, pos);
                Console.WriteLine(">");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                if (key.Key == ConsoleKey.DownArrow & pos != 3)
                {

                    pos++;
                }
                else if (key.Key == ConsoleKey.DownArrow & pos == 3)
                {

                    pos = 1;
                }
                else if (key.Key == ConsoleKey.UpArrow & pos == 1)
                {
                    pos = 3;
                }
                else if (key.Key == ConsoleKey.UpArrow & pos != 1)
                {

                    pos--;

                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    end = 1;
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.Enter & pos == 1)
                {
                    price = 5;
                    PriceX = PriceX + price;
                    cake.CountKorzh = "Один корж";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово!");
                    Thread.Sleep(700);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.Enter & pos == 2)
                {
                    price = 10;
                    PriceX = PriceX + price;
                    cake.CountKorzh = "Два коржа";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово!");
                    Thread.Sleep(700);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.Enter & pos == 3)
                {
                    price = 15;
                    PriceX = PriceX + price;
                    cake.CountKorzh = "Три коржа";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово!");
                    Thread.Sleep(700);
                    Console.Clear();
                }

            }
        }
        static void CakeGlazur()
        {
            int pos = 1;
            int end = 0;
            int price = 0;
            Console.Clear();

            while (end != 1)
            {
                Console.WriteLine("Выберите глазурь для торта:");
                Console.WriteLine($"  Без глазури (0$)");
                Console.WriteLine($"  Шоколадная глазурь (5$)");
                Console.WriteLine("  Карамельная глазурь (5$)");
                Console.WriteLine($"  Клубничная глазурь (5$)");
                Console.WriteLine($"  Ягодная глазурь (5$)");
                Console.WriteLine($"  Bubble-Gum глазурь (10$)");
                Console.SetCursorPosition(0, pos);
                Console.WriteLine(">");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                if (key.Key == ConsoleKey.DownArrow & pos != 6)
                {

                    pos++;
                }
                else if (key.Key == ConsoleKey.DownArrow & pos == 6)
                {

                    pos = 1;
                }
                else if (key.Key == ConsoleKey.UpArrow & pos == 1)
                {
                    pos = 6;
                }
                else if (key.Key == ConsoleKey.UpArrow & pos != 1)
                {

                    pos--;

                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    end = 1;
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.Enter & pos == 1)
                {
                    cake.Glazur = "Без глазури";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово!");
                    Thread.Sleep(700);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.Enter & pos == 2)
                {
                    price = 5;
                    PriceX = PriceX + price;
                    cake.Glazur = "Шоколадная";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово!");
                    Thread.Sleep(700);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.Enter & pos == 3)
                {
                    price = 5;
                    PriceX = PriceX + price;
                    cake.Glazur = "Карамельная";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово!");
                    Thread.Sleep(700);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.Enter & pos == 4)
                {
                    price = 5;
                    PriceX = PriceX + price;
                    cake.Glazur = "Клубничная";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово!");
                    Thread.Sleep(700);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.Enter & pos == 5)
                {
                    price = 5;
                    PriceX = PriceX + price;
                    cake.Glazur = "Ягодная";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово!");
                    Thread.Sleep(700);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.Enter & pos == 6)
                {
                    price = 10;
                    PriceX = PriceX + price;
                    cake.Glazur = "Bubble-Gum";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово!");
                    Thread.Sleep(700);
                    Console.Clear();
                }
            }
        }
        static void CakeDecor()
        {
            int pos = 1;
            int end = 0;
            int price = 0;
            Console.Clear();

            while (end != 1)
            {
                Console.WriteLine("Выберите глазурь для торта:");
                Console.WriteLine($"  Без декора (0$)");
                Console.WriteLine($"  Классический (10$)");
                Console.WriteLine("  Восточный (10$)");
                Console.WriteLine($"  Американский (10$)");
                Console.WriteLine($"  Римская империя (15$)");
                Console.WriteLine($"  Brawl Stars (30$)");
                Console.SetCursorPosition(0, pos);
                Console.WriteLine(">");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                if (key.Key == ConsoleKey.DownArrow & pos != 6)
                {

                    pos++;
                }
                else if (key.Key == ConsoleKey.DownArrow & pos == 6)
                {

                    pos = 1;
                }
                else if (key.Key == ConsoleKey.UpArrow & pos == 1)
                {
                    pos = 6;
                }
                else if (key.Key == ConsoleKey.UpArrow & pos != 1)
                {

                    pos--;

                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    end = 1;
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.Enter & pos == 1)
                {
                    cake.Decor = "Без декора";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово!");
                    Thread.Sleep(700);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.Enter & pos == 2)
                {
                    price = 10;
                    PriceX = PriceX + price;
                    cake.Decor = "Классический";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово!");
                    Thread.Sleep(700);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.Enter & pos == 3)
                {
                    price = 10;
                    PriceX = PriceX + price;
                    cake.Decor = "Восточный";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово!");
                    Thread.Sleep(700);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.Enter & pos == 4)
                {
                    price = 10;
                    PriceX = PriceX + price;
                    cake.Decor = "Американский";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово!");
                    Thread.Sleep(700);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.Enter & pos == 5)
                {
                    price = 15;
                    PriceX = PriceX + price;
                    cake.Decor = "Римская империя";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово!");
                    Thread.Sleep(700);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.Enter & pos == 6)
                {
                    price = 30;
                    PriceX = PriceX + price;
                    cake.Decor = "Brawl Stars";
                    end = 1;
                    Console.Clear();
                    Console.WriteLine("Готово!");
                    Thread.Sleep(700);
                    Console.Clear();
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
}
