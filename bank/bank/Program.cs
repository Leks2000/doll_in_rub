using System;
// ввести количество денег 1 валюты, вывести курс валюты 1 - 2, процент налога, если < 500 - 8, > 500 - %
class Program
{
    public static void Main()
    {
        {   
            Console.WriteLine("1 доллар = " + 65);
            var going = true;
            while (going)
            {

                Console.WriteLine("Введите количество денег: ");
                var str = Console.ReadLine();
                int znach = int.Parse(str);
                int b = 65;
                float c = 0.37f;
                var result = znach * b;
                var result1 = result - 8;
                float result2 = result - (result * c / 100);
                
                Console.WriteLine("Процент налога: " + c);
                if (znach < 500)
                {
                    Console.WriteLine("С перевода на нынешний курс получилось с налогом в 8 рублей: " + result1);
                }
                else
                {
                    Console.WriteLine("С перевода на нынешний курс получилось с налогом в 0.37%: " + result2);
                }
            }
        }
    }
}