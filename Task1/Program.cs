using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст кошки");
            string s=Console.ReadLine();
            int age = Convert.ToInt32(s);
            var cat = new Cat(age);
            int i;
            do
            {
                Console.WriteLine("\nName: ");
                Console.WriteLine(cat.Name);
                Console.WriteLine("Age: ");
                Console.Write(cat.Age);
                Console.WriteLine("\nColor: ");
                Console.WriteLine(cat.CurrentColor);
                Console.Write("Меню:\n1) Задать имя\n2) Задать цвет\n3) Ударить\n4) Покормить\n5) Выйти\nВаше решение: ");
                s = Console.ReadLine();
                i = Convert.ToInt32(s);
                
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Введите имя: ");
                        s = Console.ReadLine();
                        cat.Name = s;
                        break;
                    case 2:
                        Console.WriteLine("Введите цвет здоровой кошки: ");
                        s = Console.ReadLine();
                        cat.Color.HealthyColor = s;
                        Console.WriteLine("Введите цвет больной кошки: ");
                        s = Console.ReadLine();
                        cat.Color.SickColor = s;
                        break;
                    case 3:
                        cat.Punish();
                        break;
                    case 4:
                        cat.Feed();
                        break;
                    case 5:
                        Console.WriteLine("Вы решили выйти");
                        break;
                }
                    Console.Write("\n\t\t\tНажмите любую клавишу...");
                    Console.ReadLine();
                    Console.Clear();
                }
                while (i != 5);
            }
    }
}
