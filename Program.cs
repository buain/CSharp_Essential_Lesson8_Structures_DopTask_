using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserBirthDay
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now; // Сегодняшняя дата
            Console.WriteLine("Введите месяц своего рождения"); // Ввод пользователем месяц рождения
            int y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите день своего рождения"); // Ввод пользователем день рождения
            int z = Int32.Parse(Console.ReadLine());
            DateTime UserBirthDay = new DateTime(2018, y, z);  //Дата рождения пользователя
            TimeSpan left = today - UserBirthDay;     // Дни до дня рождения
            if (UserBirthDay < today)
            {
                Console.WriteLine("До дня рождения осталось " + (365 - left.Days) + " дней");
            }
            else 
            Console.WriteLine("До дня рождения осталось "+ left.Days +" дней");
            Console.ReadKey();
        }
    }
}
