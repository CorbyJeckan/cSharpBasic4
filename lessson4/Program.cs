//using System;//lesson 4_1

//namespace lesson4_1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(GetFullName("Иванович", "Иван", "Иванов"));
//            Console.WriteLine(GetFullName("Путин", "Владимир", "Владимирович"));
//            Console.WriteLine(GetFullName("Дальтонович", "Игорь", "Паранжов"));
//        }

//        static string GetFullName(string lastName, string firstName, string patronymic)
//        {
//            return $"{lastName} {firstName} {patronymic}";
//        }
//    }
//}

//lesson 4_2
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.UTF8;

//            ShowProgrammFunctionality();

//            /*
//             * Прочитать строку из консоли - RecieveData();
//             * Разделить строку на части(через пробел) - SplitData();
//             * Сконвертировать строки в число(parse) - TransformData();
//             * Просуммировать числа - CalculateData();
//             * Вывести на консоль результат - DisplayResult();
//             */
//            string data = RecieveData();
//            List<string> parts = SplitData(data);
//            List<int> numbers = TransformData(parts);
//            int result = CalculateData(numbers);
//            DisplayResult(result);
//        }

//        private static void ShowProgrammFunctionality()
//        {
//            Console.WriteLine("Программа, принимающую на вход строку — набор чисел, разделенных пробелом, и возвращающую число — сумму всех чисел в строке.");
//        }

//        private static string RecieveData()
//        {
//            Console.Write("Введите строку: ");
//            return Console.ReadLine();
//        }

//        private static List<string> SplitData(string data)
//        {
//            List<string> parts = new List<string>();
//            if (string.IsNullOrWhiteSpace(data))
//            {
//                return parts;
//            }
//            parts.AddRange(data.Split(' '));
//            return parts;
//        }

//        private static List<int> TransformData(List<string> parts)
//        {
//            List<int> numbers = new List<int>();
//            foreach (var part in parts)
//            {
//                if (int.TryParse(part, out int number))
//                {
//                    numbers.Add(number);
//                }
//            }
//            return numbers;
//        }

//        private static int CalculateData(List<int> numbers)
//        {
//            int result = 0;
//            foreach (var number in numbers)
//            {
//                result += number;
//            }
//            return result;
//        }

//        private static void DisplayResult(int result)
//        {
//            Console.WriteLine("Сумма чисел : " + result);
//        }
//    }
//}

////lesson4_3
//using System;

//namespace ConsoleApp
//{

//    class Program
//    {
//        enum season { NaN, Winter, Spring, Summer, Autumn }
//        static season OfMonth(int n)
//        {
//            try
//            {
//                if (n <= 0 || n > 12)
//                    throw new Exception("Ошибка: введите число от 1 до 12");
//                switch ((n % 12) / 3)
//                {
//                    case 0:
//                        return season.Winter;
//                    case 1:
//                        return season.Spring;
//                    case 2:
//                        return season.Summer;
//                    default: return season.Autumn;
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//                return season.NaN;
//            }
//        }
//        static string Season(season s)
//        {
//            switch (s)
//            {
//                case season.Winter:
//                    return "Зима";
//                case season.Spring:
//                    return "Весна";
//                case season.Summer:
//                    return "Лето";
//                case season.Autumn:
//                    return "Осень";
//                default: return "";
//            }
//        }
//        static void Main(string[] args)
//        {
//            do
//            {
//                Console.WriteLine("Введите номер месяца: ");
//                Console.WriteLine(Season(OfMonth(Convert.ToInt32(Console.ReadLine()))));
//            }
//            while (true);
//        }

//    }
//}
////выполнил дз 4//