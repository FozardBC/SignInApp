using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public static class Login
    {
        public static string logIn;
        public static string passIn;
        private static bool authLog = false;
        private static bool authPass = false;
        
        static int logCounter = 0;
        static int _try = 0;

        public static void login()
        {
            string[] data = OpenFile.ReadAndWrite(Paths.logins);

            do
            {
                Console.WriteLine("Введите логин:");
                logIn = Console.ReadLine();

                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] == logIn)
                    {
                        authLog = true;
                        logCounter = i;
                        break;
                    }
                    else Console.WriteLine("Пользователя с таким именем не существует.");
                }

            }
            while (authLog == false);

            if (authLog == true)
            {
                password();
            }
        }

        private static void password() 
        {
            string[] data = OpenFile.ReadAndWrite(Paths.passwords);

            if (authLog == true)
            {
                Console.Clear();
                do
                {
                    Console.WriteLine("У вас 3 попытки! Введите пароль:");
                    passIn = Console.ReadLine();
                    if (passIn == data[logCounter])
                    {
                        authPass = true;
                        Console.WriteLine("Пароль верный. Добро пожаловать.");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        _try++;
                        Console.WriteLine($"Пароль неверный. Количестов оставшихся попыток: {3 - _try}.");
                    }
                }
                while (authPass == false | _try < 2);
            }
        }
    }
}
