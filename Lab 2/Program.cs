using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, father, family, number;

            Console.Write("Введите имя: ");

            name = Console.ReadLine();

            Console.WriteLine("Имя: " + name);

            Console.Write("Введите отчество: ");

            father = Console.ReadLine();

            Console.WriteLine("Отчество: " + father);

            Console.Write("Введите фамилию: ");

            family = Console.ReadLine();

            Console.WriteLine("Фамилия: " + family);

            Console.Write("Введите номер: ");

            number = Console.ReadLine();

            Console.WriteLine("Номер: " + number);

            Console.WriteLine("Здравствуйте " + name + " " + father + " " + family + "." + " Вы " + number + " по списку");
        }
    }
}
