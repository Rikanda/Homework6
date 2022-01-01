using System;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            // простая проверка сравнения банковских счетов
            BankAccount b1 = new BankAccount()
            { NumberAccount = 1111,
            BalanceAccount=10000,
            TypeAccount=Type.Дебетовый
            };
            Console.WriteLine(b1.ToString());
            Console.WriteLine($"Хэш-код: {b1.GetHashCode()}");
            BankAccount b2 = new BankAccount()
            {
                NumberAccount = 1111,
                BalanceAccount = 10000,
                TypeAccount = Type.Дебетовый
            };
            Console.WriteLine(b2.ToString());
            Console.WriteLine($"Хэш-код: {b2.GetHashCode()}");
            BankAccount b3 = new BankAccount()
            {
                NumberAccount = 1111,
                BalanceAccount = 10000,
                TypeAccount = Type.Кредитовый
            };
            Console.WriteLine(b3.ToString());
            Console.WriteLine($"Хэш-код: {b3.GetHashCode()}");

            if (b1 == b2)
                Console.WriteLine("Счета совпадают");
            else
                Console.WriteLine("Счета не совпадают");

            if (b1 == b3)
                Console.WriteLine("Счета совпадают");
            else
                Console.WriteLine("Счета не совпадают");

            if(b1.Equals(b3))
               Console.WriteLine("Счета совпадают");
            else
               Console.WriteLine("Счета не совпадают");


        }
    }
}
