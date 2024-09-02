using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.WriteLine("Введите имя и фамилию: ");
            string nameSurname = Console.ReadLine();
            NameSurname(nameSurname);
            Console.ReadKey();
        }
        public static void NameSurname(string nameSurname)
        {
            Console.WriteLine(nameSurname);
        }
    }
}
