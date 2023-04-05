using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _3_Modul._11_Dars_Linq_2Example
{
    public class HomeTask30Talik
    {
        public static void Tasks()
        {
            Task24();
        }

        public static void Task1()
        {
            List<int> list = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var Query = from number in list
                        where number % 2 == 0
                        select number;
            foreach (var item in Query)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("#_________#__________#");

            var Method = list.Where(obj => obj % 2 == 0).ToArray();
            foreach (var item in Method)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("#_________#________#");

            var mixed = (from number in list
                         where number % 2 == 0
                         select number).ToArray();
            foreach (var item in mixed)
            { Console.WriteLine(item); }
        }
        public static void Task2()
        {
            List<int> list = new List<int> { 1, 3, 5, 7, 9, 10, 11 };

            var Query = from number in list
                        where number > 0
                        where number < 11
                        select number;
            foreach (var item in Query)
            { Console.WriteLine(item); }

        }
        public static void Task3()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            var res = from number in numbers
                      where Math.Pow(number, 2) > 20
                      select new
                      {
                          Number = number,
                          SqrNo = Math.Pow(number, 2)
                      };
            foreach (var item in res)
            { Console.WriteLine($" number :{item.Number} : SqrNo :{item.SqrNo} "); }
        }
        public static void Task4()
        {

            int[] myArray = new int[] { 1, 2, 3, 4, 5, 5, 6, 7, 8, 9, 10, 10, 11, 11, 12, 13, 14, 15, 2, 16, 17, 18, 19, 20 };

            var counts = myArray.GroupBy(x => x)
                                .Select(x => new { Element = x.Key, Count = x.Count() });

            foreach (var item in counts)
            {
                Console.WriteLine(item.Element + " soni " + item.Count + " marta");
            }
        }
        public static void Task5()
        {
            string myString = "Salom dunyo kel birga bo'lamiz hayot go'zal va betakror deb bilaman";

            var counts = myString.GroupBy(x => x)
                .Select(x => new { Character = x.Key, Element = x.Key, Count = x.Count() });
            foreach (var item in counts)
            {
                Console.WriteLine($"Character{item.Character} {item.Element} {item.Count} times");
            }
        }
        public static void Task6()
        {
            string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            IEnumerable<string> Query = from day in dayWeek
                                        where dayWeek.Contains(day)
                                        select day;
            foreach (var day in Query)
            {
                Console.WriteLine(day);
            }
        }
        public static void Task7()
        {
            int[] myArray = new int[] { 1, 2, 3, 4, 5, 5, 6, 7, 8, 9, 10, 10, 11, 11, 12, 13, 14, 15, 2, 16, 17, 18, 19, 20 };

            var counts = myArray.GroupBy(x => x)
                .Select(x => new { Element = x.Key, Count = x.Count() });

            foreach (var item in counts)
            {
                Console.WriteLine(item.Element + "Soni " + "Ko'paytmasi :" + (item.Element * item.Count) + item.Count);
            }
        }
        public static void Task8()
        {
            string[] cities = new string[] { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            char startChar = 'R';
            char endChar = 'E';

            string result = cities.FirstOrDefault(city => city.StartsWith(startChar) && city.EndsWith(endChar));

            Console.WriteLine(result);

        }
        public static void Task9()
        {
            int[] numbers = new int[] { 55, 200, 740, 76, 230, 482, 95 };

            var myQuery = from number in numbers
                          where number > 80
                          select number;
            foreach (var item in myQuery)
            {
                Console.WriteLine(item);
            }
        }
        public static void Task10()
        {

            List<int> numbers = new List<int>();
            Console.Write("Elementlar soni : ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Member {i} : ");
                int num = int.Parse(Console.ReadLine());
                numbers.Add(num);
            }

            Console.Write("Listdagi sonlar undan katta bo'ladigan qiymat : ");
            int threshold = int.Parse(Console.ReadLine());

            var results = numbers.Where(num => num > threshold);

            Console.WriteLine("Result :");
            Console.WriteLine($"{threshold} dan katta sonlar:");
            foreach (int num in results)
            {
                Console.WriteLine(num);
            }
        }
        public static void Task11()
        {
            List<int> numbers = new List<int> { 5, 7, 13, 24, 6, 9, 8, 7 };
            Console.WriteLine("List of integers :");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.Write("Nechta top kattalari ? : ");
            int n = int.Parse(Console.ReadLine());

            var results = numbers.OrderByDescending(num => num).Take(n);

            Console.WriteLine("Result :");
            Console.WriteLine($"Top {n} kattalari :");
            foreach (int num in results)
            {
                Console.WriteLine(num);
            }
        }
        public static void Task13()
        {
            string[] animals = new string[] { "cat", "dog", "rat", "Olma", "Sabzi", "Quyon" };
            Console.Write("Nechta element : ");
            int n = int.Parse(Console.ReadLine());

            string result = string.Join(", ", animals.Take(n));

            Console.WriteLine($"{n} ta array element :");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Element[{i}] : {animals[i]}");
            }

            Console.WriteLine("Natija :");
            Console.WriteLine($"\"{result}\"");
        }
        public static void Task17()
        {
            List<char> chars = new List<char>() { 'm', 'n', 'o', 'p', 'q' };
            Console.Write("Listdan o'chirish uchun charni kiriting : ");
            char removeChar = char.Parse(Console.ReadLine());

            List<char> result = chars.Where(c => c != removeChar)
                                     .ToList();

            Console.WriteLine("Listdan '{0}' ni o'chirgandan keyingi natija :", removeChar);
            foreach (char c in result)
            {
                Console.WriteLine($"Char: {c}");
            }
        }
        public static void Task18()
        {
            List<char> chars = new List<char>() { 'm', 'n', 'o', 'p', 'q' };
            chars.ForEach(x => Console.Write(x + ", "));
            Console.WriteLine();
            Console.WriteLine("Qanday  belgini o'chirmoqchisiz? ");
            Console.Write(">> ");
            char a = char.Parse(Console.ReadLine()!);
            var deletChar = from del in chars
                            where del != a
                            select del;
            foreach (var item in chars)
            {
                Console.Write(item + ", ");
            }
        }
        public static void Task19()
        {
            List<char> chars = new List<char>() { 'm', 'n', 'o', 'p', 'q' };
            chars.ForEach(x => Console.Write(x + ", "));
            Console.WriteLine();
            chars.RemoveAll(x => x == 'o');
        }
        public static void Task20()
        {
            List<char> chars = new List<char>() { 'm', 'n', 'o', 'p', 'q' };
            Console.WriteLine("Indeksni kiriting:");
            Console.Write(">> ");
            int index = Convert.ToInt32(Console.ReadLine()!);
            chars.RemoveAt(index);
        }
        public static void Task21() {
            List<char> chars = new List<char>() { 'm', 'n', 'o', 'p', 'q' };
            Console.WriteLine("Indeksni kiriting:");
            Console.Write(">> ");
            int index = Convert.ToInt32(Console.ReadLine()!);
            Console.WriteLine("Oraliqni kiriting:");
            Console.WriteLine(">> ");
            int oraliq = Convert.ToInt32(Console.ReadLine()!);
            chars.RemoveRange(index, oraliq);
            chars.ForEach(x => Console.Write(x + " "));
        }
        public static void Task22() {
            List<string> myStrings = new List<string> { "this", "is", "a", "string" };
            Console.WriteLine("Minimum uzunlikni kiriting: ");
            Console.Write(">> ");
            int n = int.Parse(Console.ReadLine());
            var list = (from ll in myStrings
                        where ll.Length > n
                        select ll).ToList();
            list.ForEach(x => Console.Write(x + ", "));
        }
        public static void Task23()
        {
            var letterList = new[] { "X", "Y", "Z","F","G" };
            var numberList = new[] { 1, 2, 3, 4,5,6,7,8 };

            var cartesianProduct = from letter in letterList
                                   from number in numberList
                                   select new { letterList = letter, numberList = number };

            foreach (var item in cartesianProduct)
            {
                Console.WriteLine("{ letterList = " + item.letterList + ", numberList = " + item.numberList + " }");
            }
        }


        public static void Task24()
        {
            int[] numbers = new int[] {1,2,3};
            char[] strings =  new char[] {'X','Y','Z'};
            string[] colours = new string[] { "Yashil ", "Qizil","Sariq"};
            var crossJoin = from num1 in numbers
                            from str in strings
                            from colour in colours
                            select new { numbers = num1, strings = str, colours = colour};
            foreach (var item in crossJoin)
            {
                Console.WriteLine("{ letter = "+item.strings+", number = "+item.numbers + ", Colour = "+item.colours);
            }
            //{ letter = X, number = 1, colour = Green }
            //{ letter = X, number = 1, colour = Orange }
            //{ letter = X, number = 2, colour = Green }
            //{ letter = X, number = 2, colour = Orange }
            //{ letter = X, number = 3, colour = Green }
            //{ letter = X, number = 3, colour = Orange }
            //{ letter = Y, number = 1, colour = Green }
            //{ letter = Y, number = 1, colour = Orange }


        }
        public static void Task25() {

            List<Order> orders = new List<Order>

        {
            new Order { OrderId = 1, CustomerId = 1, Amount = 100.00M },
            new Order { OrderId = 2, CustomerId = 2, Amount = 50.00M },
            new Order { OrderId = 3, CustomerId = 3, Amount = 200.00M }
        };

            List<Customer> customers = new List<Customer>
        {
            new Customer { CustomerId = 1, Name = "Alice" },
            new Customer { CustomerId = 2, Name = "Bob" },
            new Customer { CustomerId = 3, Name = "Charlie" },
            new Customer { CustomerId = 4, Name = "David" }
        };

            var innerJoin = from order in orders
                            join customer in customers
                            on order.CustomerId equals customer.CustomerId
                            select new
                            {
                                customer.CustomerId,
                                customer.Name,
                                order.Amount,
                                order.OrderId
                            };
            Console.WriteLine("Item Id\t\tItem Name\tPurchase Quantity");
            foreach (var item in innerJoin)
            {
                Console.WriteLine($"{item.CustomerId}\t\t{item.Name}\t\t{item.Amount}");
            }
        }

        public static void Task26() {
            List<Item> items = new()
            {
                new Item {itemId = 1, itemName = "Biscuit", itemPriceId = 1},
                new Item {itemId = 2, itemName = "Chocolate", itemPriceId = 2},
                new Item {itemId = 3, itemName = "Butter", itemPriceId = 1},
                new Item {itemId = 4, itemName = "Brade", itemPriceId = 3},
                new Item {itemId = 5, itemName = "Honey", itemPriceId = 5},
            };
            List<Purchase> purchases = new()
            {
                new Purchase { id = 1, price = 12000 },
                new Purchase { id = 2, price = 25000 },
                new Purchase { id = 3, price = 5000 },
                new Purchase { id = 4, price = 6000 },
                new Purchase { id = 5, price = 78000 },
            };
            var leftJoin = from item in items
                           join purchase in purchases
                           on item.itemPriceId equals purchase.id
                           into selectedItem
                           from newItem in selectedItem.DefaultIfEmpty()
                           select new
                           {
                               id = item.itemId,
                               name = item.itemName,
                               price = newItem
                           };
            Console.WriteLine("Item ID\t\tItem Name\tItem Price");
            Console.WriteLine("-------------------------------------------------");
            foreach (var item in leftJoin)
            {
                Console.WriteLine($"{item.id}\t\t{item.name}\t\t{item.price.price}");
            }
        }


        public static void Task27()
        {
            List<Purchase> purchases = new()
            {
                new Purchase { id = 1, price = 12000 },
                new Purchase { id = 2, price = 25000 },
                new Purchase { id = 3, price = 5000 },
                new Purchase { id = 4, price = 6000 },
                new Purchase { id = 5, price = 78000 },
            };
            List<Item> items = new()
            {
                new Item {itemId = 1, itemName = "Biscuit", itemPriceId = 1},
                new Item {itemId = 2, itemName = "Chocolate", itemPriceId = 2},
                new Item {itemId = 3, itemName = "Butter", itemPriceId = 1},
                new Item {itemId = 4, itemName = "Brade", itemPriceId = 3},
                new Item {itemId = 4, itemName = "Brade", itemPriceId = 4},
                new Item {itemId = 5, itemName = "Honey", itemPriceId = 5},
            };
            var rightJoin = from purchase in purchases
                            join item in items
                            on purchase.id equals item.itemPriceId
                            into purchItem
                            from newPurchItem in purchItem.DefaultIfEmpty()
                            select new
                            {
                                purchase.id,
                                purchase.price,
                                newPurchItem.itemName
                            };
            Console.WriteLine("Item ID\t\tItem Name\tItem Price");
            Console.WriteLine("-------------------------------------------------");
            foreach (var item in rightJoin)
            {
                Console.WriteLine($"{item.id}\t\t{item.itemName}\t\t{item.price}");
            }
        }

    public static void Task28()
    {
        List<string> cities = new List<string>()
        {
            "ROME",
            "PARIS",
            "LONDON",
            "ZURICH",
            "NAIROBI",
            "ABU DHABI",
            "NEW DELHI",
            "CALIFORNIA",
            "AMSTERDAM",
        };
        var task28 = (from city in cities
                      orderby city.Length
                      select city).ThenBy(x => x);
        foreach (var item in task28)
        {
            Console.WriteLine(item);
        }
    }

    public static void Task29()
    {
        string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS", "NEW YORK" };
        var groupOfCities = from city in cities
                            group city by Array.IndexOf(cities, city) / 3
                            into groupCity
                            select groupCity;
        foreach (var group in groupOfCities)
        {
            foreach (var city in group)
            {
                Console.Write(city + "; ");
            }
            Console.WriteLine();
        }
    }


    public static void Task30()
    {
        List<string> cities = new List<string>()
        {
            "TASHKENT",
            "SAMARQAND",
            "TERMIZ",
            "ANDIAN",
            "FERGANA",
            "NAMANGAN",
            "ANDIJAN",
            "NEW DELHI",
            "AMSTERDAM",
            "PARIS",
            "NEW DELHI",
            "NEW DELHI",
        };
        var distinctList = (from city in cities
                            orderby city
                            select city).Distinct();
        foreach (var item in distinctList)
        {
            Console.WriteLine(item);
        }
    }
}
class Item
{
    public int itemId { get; set; }
    public string? itemName { get; set; }
    public int itemPriceId { get; set; }
}

class Purchase
{
    public int id { get; set; }
    public int price { get; set; }
}


class Order
{
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public decimal Amount { get; set; }
}
class Customer
{
    public int CustomerId { get; set; }
    public string? Name { get; set; }
}


record Student2(int Id, string Name, int Ball);
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Ball { get; set; }
}
}



