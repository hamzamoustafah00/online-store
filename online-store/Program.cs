using System;
namespace online_store;

    class Program
    {
        static void Main(string[] args)
        {
            Welcome();
            PurchaseItem();
        }

        static void Welcome()
        {
            Console.WriteLine("Welcome to the store! Here are the items:");
            Console.WriteLine("1. Book");
            Console.WriteLine("2. Shirt");
            Console.WriteLine("3. Computer");
            Console.WriteLine("What would you like to buy?");
        }

        static void PurchaseItem()
        {
            var item = Console.ReadLine();

            switch (item)
            {
                case "Book":
                    var book = new Book();
                    book.Author = "JK Author";
                    book.Title = "The Wizard";
                    book.Price = 9.99;
                    Console.WriteLine($"You Purchased a {book.Author} {book.Title} for ${book.Price}");
                    break;
                case "Shirt":
                    var shirt = new Shirt();
                    shirt.Size = "M";
                    shirt.Title = "Sport";
                    shirt.Price = 14.99;
                    Console.WriteLine($"You Purchased a {shirt.Title} (Size: {shirt.Size}) for ${shirt.Price}");
                    break;
                case "Computer":
                    var computer = new Computer();
                    computer.Type = "PC";
                    computer.Title = "Macbook";
                    computer.Price = 1499.99;
                    Console.WriteLine($"You Purchased a {computer.Title} ({computer.Type}) for ${computer.Price}");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid item.");
                    break;
            }

            Console.ReadLine();
        }
    }

    
