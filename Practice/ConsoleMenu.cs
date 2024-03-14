using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class ConsoleMenu
    {
        int counter = 0;
        public string[] menuItems { get; set; }
        public int PrintMenu() // печатает меню и позволяет выбрать элемент интерфейса
        {
            ConsoleKeyInfo key;
            do
            {
                Console.Clear();
                for (int i = 0; i < menuItems.Length; i++)
                {
                    if (counter == i)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(menuItems[i]);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else Console.WriteLine(menuItems[i]);
                }
                key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            counter--;
                            if (counter < 0)
                                counter = 1;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        counter++;
                        if (counter > menuItems.Length - 1)
                            counter = 0;
                        break;
                }
            }

            while (key.Key != ConsoleKey.Enter);
            return counter; // вся тема возвращает ИНТ счётчик, который потом должен выбирать пункт меню
        }
    }
}
