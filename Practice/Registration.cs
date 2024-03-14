using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public static class Registration
    {
        static string logIn;
        static string passIn;
        const string warnSymb = "Не используйте знаки ; и :";
        const string exepSymb = "Вы ввели недопустимые символы! Введите еще логин раз: ";


        public static void EnterLogin ()
        {
            Console.Clear();
            Console.WriteLine("Добро пожаловать в регистрацию администратора");
            Console.WriteLine(warnSymb);
            Console.WriteLine("Напишите логин: ");

            logIn = Console.ReadLine();

            if (logIn.Contains(';') || logIn.Contains(':'))
            {
                Console.WriteLine(exepSymb);
                logIn = Console.ReadLine();
            }
            else
                OpenFile.Open(logIn, Paths.logins);
                 
        }
        
        public static void EnterPassword()
        {
            Console.Clear();
            Console.WriteLine(warnSymb);
            Console.WriteLine("Придумайте пароль:");

            passIn = Console.ReadLine();

            if (passIn.Contains(';') || passIn.Contains(':'))
            {
                Console.WriteLine(exepSymb);
                passIn = Console.ReadLine();
            }
            else
                OpenFile.Open(passIn, Paths.passwords);

            Console.WriteLine($"Был создан пользователь {logIn} с паролем {passIn}");
            Console.WriteLine($"Обязательно запишите логин или пароль. Возможности восстановить пароль - нет");
            
        }
                        
    }
}
