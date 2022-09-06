// ввести количество денег 1 валюты, вывести курс валюты 1 - 2, процент налога, если < 500 - 8, > 500 - %
{
    string str;
    Console.Write("Введите количество денег: ");
    str = Console.ReadLine();
    int a = int.Parse(str);
    int b = 65;
    float c = 0.37f;
    int result = a * b;
    int result1 = result - 8;
    float result2 = result - (result * c / 100);
     Console.WriteLine("1 доллар = " + b);
        Console.WriteLine("Процент налога: " + c);
     Console.WriteLine("С перевода на нынешний курс получилось без налога: " + result);
    if (a < 500)
    {
        Console.WriteLine("С перевода на нынешний курс получилось с налогом в 8 рублей: " + result1);
    }
    else
    {
        Console.WriteLine("С перевода на нынешний курс получилось с налогом в 0.37%: " + result2);
    }
}