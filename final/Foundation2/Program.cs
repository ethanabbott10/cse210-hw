using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Batch batch = new Batch();
        int _userInput = 0;
        while (_userInput != 3)
        {
            Console.Clear();
            Console.WriteLine("Welcome! Please select on of the following options:");
            Console.WriteLine();
            Console.WriteLine("1). Place an order");
            Console.WriteLine("2). Display Orders");
            Console.WriteLine("3). Quit");
            Console.WriteLine();
            Console.Write("Please select the number of the action you would like to take: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out _userInput))
            {
                Console.Clear();
                Console.WriteLine("Please make a valid selection.");
                _userInput = 0;
                Console.ReadKey();
                continue;

            }
            
            switch (_userInput)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("What is your name?");
                    string name = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What is your address? (Please follow this format: Address, City, State (if there is no state, don't but anything between the commas), Country (USA or Other))");
                    string addressString = Console.ReadLine();
                    Address address = new Address(addressString);
                    Customer customer = new Customer(name, address);
                    Order order = new Order(customer);
                    int _secondInput = 0;
                    while (_secondInput != 11)
                    {
                        Console.Clear();
                        Console.WriteLine("Here are our products:");
                        Console.WriteLine();
                        Console.WriteLine("1). Crystal Spring Water (12oz) - $1.49");
                        Console.WriteLine("2). SolarCharge Portable Battery - $24.99");
                        Console.WriteLine("3). Velvet Mist Scented Candle - $8.75");
                        Console.WriteLine("4). Arctic Trail Insulated Bottle - $17.95");
                        Console.WriteLine("5). Neon Edge Gaming Mousepad - $13.50");
                        Console.WriteLine("6). CloudSoft Memory Foam Pillow - $29.99");
                        Console.WriteLine("7). SnapBloom Desk Plant (Artificial) - $6.25");
                        Console.WriteLine("8). GlowByte USB LED Strip (5ft) - $11.99");
                        Console.WriteLine("9). HexaGrip Phone Stand - $4.95");
                        Console.WriteLine("10). EverBean Cold Brew Kit - $34.50");
                        Console.WriteLine("11). All done");
                        Console.WriteLine();
                        Console.WriteLine("Which prodcut would you like to purchase? (Please use the product ID number)");
                        string secondinput = Console.ReadLine();

                        if (int.TryParse(secondinput, out _secondInput))
                        {
                            switch (_secondInput)
                            {
                                case 1:
                                    Product water = new Product(1, "Crystal Spring Water (12 oz)", 1.49, GetQuantity());
                                    order.AddProduct(water);
                                    break;

                                case 2:
                                    Product battery = new Product(2, "SolarCharge Portable Battery", 24.99, GetQuantity());
                                    order.AddProduct(battery);
                                    break;

                                case 3:
                                    Product candle = new Product(3, "Velvet Mist Scented Candle", 8.75, GetQuantity());
                                    order.AddProduct(candle);
                                    break;

                                case 4:
                                    Product bottle = new Product(4, "Arctic Trail Insulated Bottle", 17.95, GetQuantity());
                                    order.AddProduct(bottle);
                                    break;

                                case 5:
                                    Product mousepad = new Product(5, "Neon Edge Gaming Mousepad", 13.50, GetQuantity());
                                    order.AddProduct(mousepad);
                                    break;

                                case 6:
                                    Product pillow = new Product(6, "CloudSoft Memory Foam Pillow", 29.99, GetQuantity());
                                    order.AddProduct(pillow);
                                    break;

                                case 7:
                                    Product plant = new Product(7, "SnapBloom Desk Plant (Artificial)", 6.25, GetQuantity());
                                    order.AddProduct(plant);
                                    break;

                                case 8:
                                    Product ledStrip = new Product(8, "GlowByte USB LED Strip (5ft)", 11.99, GetQuantity());
                                    order.AddProduct(ledStrip);
                                    break;

                                case 9:
                                    Product phoneStand = new Product(9, "HexaGrip Phone Stand", 4.95, GetQuantity());
                                    order.AddProduct(phoneStand);
                                    break;

                                case 10:
                                    Product brewKit = new Product(10, "EverBean Cold Brew Kit", 34.50, GetQuantity());
                                    order.AddProduct(brewKit);
                                    break;
                                
                                case 11:
                                    Console.Clear();
                                    Console.WriteLine("Thank you for your order!");
                                    Console.ReadKey();
                                    break;

                                default:
                                    Console.Clear();
                                    Console.WriteLine("Please make a valid selection");
                                    Console.ReadKey();
                                    break;
                            }
                        }

                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Please make a valid selection");
                            Console.ReadKey();
                        }

                    }

                    batch.AddOrder(order);
                    break;

                case 2:
                    if (batch.GetBatchSize() == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("You have no orders.");
                        Console.ReadKey();
                    }

                    else
                    {
                        Console.Clear();
                        batch.DisplayOrders();
                        Console.ReadKey();
                    }
                    break;
            }
        }

    }

    static int GetQuantity()
    {
        int _quantity;

        Console.WriteLine("How many would you like to purchase?");
        string response = Console.ReadLine();

        while (true)
        {
            if (int.TryParse(response, out _quantity) && _quantity > 0)
            {
                return _quantity;
            }

            Console.WriteLine("Please input a whole number greater than 0");
        }
    }
    
}