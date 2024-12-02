using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            string name;
            string surname;
            string patronymic;
            int age;
            string cityOfResidence;
            string signZodiac;
            string currentPosition;
            string positiveQualities;
            string negativeQualities;
            string desiredPosition;
            string preferredSalary;

            Console.WriteLine("Здравствуйте, меня зовут Олег, менеджер студии разработки игр AVAGA");
            Console.Write("Введите ваше Имя: ");
            name = Console.ReadLine();
            Console.Write("Введите вашу Фамилию: ");
            surname = Console.ReadLine();
            Console.Write("Введите ваше Отчество: ");
            patronymic = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите город в котором проживаете: ");
            cityOfResidence = Console.ReadLine();
            Console.Write("Введите ваш знак зодиака: ");
            signZodiac = Console.ReadLine();
            Console.Write("Введите ваше текущую должность: ");
            currentPosition = Console.ReadLine();
            Console.Write("Введите ваши положительные качества: ");
            positiveQualities = Console.ReadLine();
            Console.Write("Введите ваши отрицательные качества: ");
            negativeQualities = Console.ReadLine();
            Console.Write("Введите желаемую должность: ");
            desiredPosition = Console.ReadLine();
            Console.Write("Введите какую заработную плату хотите со старта: ");
            preferredSalary = Console.ReadLine();

            Console.WriteLine($" Вас зовут {surname} {name} {patronymic}, вам {age} года(лет). По знаку зодиака вы {signZodiac}. ");
            Console.WriteLine($" В данный момент времени проживаете в городе {cityOfResidence} и ваша должность {currentPosition}. ");
            Console.WriteLine($" Своими положительными качествами считаете {positiveQualities}, а отрицательными {negativeQualities}. ");
            Console.WriteLine($" Хотите пройти собеседование на должность {desiredPosition} и хотете со старта получать {preferredSalary} рублей в месяц. ");
        }
    }
}
