using Practice;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Pra

{
    class Program
    {
        public static void Main()
        {
            Directory.CreateDirectory(@"C:\Practic10\Logins"); 
            string[] _menuItems = { "Login", "Registration" }; // тут задать элементы меню, но нужно проверить переключатель в классе ConsoleMenu

            int counter = 0; // счётчик для выбора элемента меню

            ConsoleKeyInfo key; 
            ConsoleMenu Menu = new ConsoleMenu();

            Menu.menuItems = _menuItems; 
            counter = Menu.PrintMenu(); // печатает меню и вернёт int если нажать Enter => ConsoleMenu

            if (counter == 0) // инициализурет Вход или Регистрацию
            {
                Login.login();
            }
            else
            {
                Registration.EnterLogin();
                Registration.EnterPassword();
                Menu.PrintMenu();
            }
        }
    }
}
