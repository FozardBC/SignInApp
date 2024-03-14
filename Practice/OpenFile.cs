using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practice
{
    public static class Paths
    {
        public const string logins = @"C:\\Practic10\Logins\AdminsLogs.txt";
        public const string passwords = @"C:\\Practic10\Logins\AdminsPass.txt";
    }
    class OpenFile 
    {
        public static void Open (string In, string path ) // сделай типа он передаеёт то что ввели в консоль и записывает в файл
        {
            StreamWriter SW = File.AppendText(path);
            SW.Write(In);
            SW.Close();
        }

        public static string[] ReadAndWrite (string In) // открывает файл, записывает данные из него в возвращаемые массив
        {

            string[] data;

            StreamReader SR = File.OpenText(In);
            data = SR.ReadToEnd().Split(";");
            SR.Close();

            return data;

        }
    }
}
