using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(41.0m, 44.0m);

            Console.WriteLine("=== Currency converter ===");
            Console.WriteLine("Choose the conversion direction:");
            Console.WriteLine("1. From hryvnia to currency");
            Console.WriteLine("2. From currency to hryvnia");
            Console.Write("Select the request: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter the amount in hryvnias: ");
                    decimal uah = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Choose currency: 1 - USD, 2 - EUR");
                    string curr1 = Console.ReadLine();

                    if (curr1 == "1")
                        Console.WriteLine($"Result: {converter.FromUAHtoUSD(uah):F2} USD");
                    else if (curr1 == "2")
                        Console.WriteLine($"Result: {converter.FromUAHtoEUR(uah):F2} EUR");
                    else
                        Console.WriteLine("Incorrect currency:(");
                    break;

                case "2":
                    Console.WriteLine("Choose currency: 1 - USD, 2 - EUR");
                    string curr2 = Console.ReadLine();

                    Console.Write("Enter the amount: ");
                    decimal amount = decimal.Parse(Console.ReadLine());

                    if (curr2 == "1")
                        Console.WriteLine($"Result: {converter.FromUSDtoUAH(amount):F2} грн");
                    else if (curr2 == "2")
                        Console.WriteLine($"Result: {converter.FromEURtoUAH(amount):F2} грн");
                    else
                        Console.WriteLine("Incorrect currency!");
                    break;

                default:
                    Console.WriteLine("Incorrect choice!");
                    break;
            }

            Console.WriteLine("\nThank you for using the converter!");
        }
    }
}
