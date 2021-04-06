using System;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заданеи № 1

            Console.Write("Введте минимальную температуру за сутки: ");
            double minTemp = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите максимальную температуру за сутки: ");
            double maxTemp = Convert.ToDouble(Console.ReadLine());
            double averTemp = (minTemp + maxTemp) / 2;
            Console.WriteLine($"Среднесуточкая температура составляет: {averTemp}");

            // Задание №2

            Console.Write("Введите порядковый номер текущего месяца: ");
            int month = Convert.ToInt32(Console.ReadLine());
            while (month > 12 || month < 1)
            {
                Console.Write("В году 12 месяцев. Введите орядковый номер текущего месяца от 1 до 12: ");
                month = Convert.ToInt32(Console.ReadLine());
            }

            switch (month)
            {
                case 1:
                    Console.Write("Январь \n");
                    break;

                case 2:
                    Console.Write("Февраль \n");
                    break;

                case 3:
                    Console.Write("Март \n");
                    break;

                case 4:
                    Console.Write("Апрель \n");
                    break;

                case 5:
                    Console.Write("Май \n");
                    break;

                case 6:
                    Console.Write("Июнь \n");
                    break;

                case 7:
                    Console.Write("Июль \n");
                    break;

                case 8:
                    Console.Write("Август \n");
                    break;

                case 9:
                    Console.Write("Сентябрь \n");
                    break;

                case 10:
                    Console.Write("Октябрь \n");
                    break;

                case 11:
                    Console.Write("Декабрь \n");
                    break;

                case 12:
                    Console.Write("Январь \n");
                    break;

                default:
                    Console.Write("В году 12 месяцев!");
                    break;
            }

            // Задание № 3

            if (month % 2 == 0)
                Console.WriteLine("Вы ввели четное число. \n");
            else
                Console.WriteLine("Вы ввели не четное число (не четный месяц).\n");

            // Задание № 5 (*)

            if ((month == 1 || month == 2 || month == 3) && averTemp > 0)
            {
                Console.WriteLine("Дождливая зима \n");
            }
            else if ((month == 1 || month == 2 || month == 3) && averTemp < 0)
            {
                Console.WriteLine("Обычная погода \n)");
            }
            else
            {
                Console.WriteLine("Обычная питерская погода \n)");
            }

            // Задание №4


            string cashCheck = "111";
            string nameOrg = "Лютики";
            string inn = "123456789000";
            string adress = "777000, Санкт-Петербург, ул. Воронцовская, 35 Б";
            DateTime date = new(2021, 04, 03, 23, 10, 30);
            string cashName = "Петрова Мария Ивановна";
            string[] food = { "Молоко", "Чай", "Масло" };
            int[] price = { 56, 33, 98 };
            int[] NDS = { 0, 10, 20 };
            int[] quantity = { 3, 5, 10 };
            int i = 0;



            Console.WriteLine($"{ " ",-31} Кассовый чек № {cashCheck}");
            Console.WriteLine($"{ " ",-35} ООО {nameOrg}");
            Console.WriteLine($"{ " ",-32}ИНН: {inn}");
            Console.WriteLine($"{ " ",-13} Адрес: {adress}");
            Console.WriteLine($"{ " ",-27} Дата: {date}");
            Console.WriteLine($"{ " ",-25} Кассир {cashName} \n");
            Console.WriteLine(" ".PadRight(79, '*'));
            string newLine = Environment.NewLine;
            Console.WriteLine($"{" Товар",-22} {"Количество",-25} {"Цена",-20} {"Стоимость",-20}");

            Console.WriteLine($"{food[i + 1],-22} {quantity[i],-25} {price[i],-20} {quantity[i] * price[i],-20}");
            Console.WriteLine($"НДС % {NDS[i],-20} {(quantity[i] * price[i]) * 10 / 110,45} \n");

            Console.WriteLine($"{food[i + 2],-22} {quantity[i + 1],-25} {price[i + 1],-20} {quantity[i + 1] * price[i + 1],-20}");
            Console.WriteLine($"НДС % {NDS[i + 1],-20}   {(quantity[i + 1] * price[i + 1]) * 10 / 110,43} \n");

            Console.WriteLine($"{food[i + 2],-22} {quantity[i + 2],-25} {price[i + 2],-20} {quantity[i + 2] * price[i + 2],-20}");
            Console.WriteLine($"НДС % {NDS[i + 2],-20}   {quantity[i + 2] * price[i + 2] * 10 / 110,43} \n");

            Console.WriteLine($"Итого: {quantity[i] * price[i] + quantity[i + 1] * price[i + 1] + quantity[i + 2] * price[i + 2],67 } \n");
            Console.WriteLine($"НДС  {(quantity[i] * price[i] + quantity[i + 1] * price[i + 1] + quantity[i + 2] * price[i + 2]) * 10 / 110,68} \n");
            Console.WriteLine(" ".PadRight(79, '*'));
            Console.WriteLine("Оплата наличными: 1500,00  рублей");
            Console.WriteLine("Сдача составляет: 187,00   рублей");
        }
    }
}
