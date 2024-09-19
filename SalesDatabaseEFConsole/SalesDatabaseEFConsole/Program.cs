using Microsoft.IdentityModel.Protocols;
using SalesDatabaseEFConsole.Db;
using SalesDatabaseEFConsole.Models;
using System.Numerics;

namespace SalesDatabaseEFConsole
{
    internal class Program
    {
        static CustomerDb customerDb = new CustomerDb();
        static RegionDb regionDb = new RegionDb();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Sales Database: Entity Framework Edition!");
            Console.WriteLine("Please type EXIT at any time to exit the program.\n");
            string command = "";
            command = PromptInput("Would you like to interact with customer data or region data? (c/r): ");

            while (command != "exit")
            {
                if (command == "c")
                {
                    DisplayCustomerMenu();

                    while (command != "exit")
                    {
                        command = PromptInput("Command: ");
                        switch (command)
                        {
                            case "list":
                                ListCustomers();
                                break;
                            case "get":
                                GetCustomer();
                                break;
                            case "add":
                                AddCustomer();
                                break;
                            case "del":
                                DeleteCustomer();
                                break;
                            case "exit":
                                break;
                            default:
                                Console.WriteLine("Invalid command.  Try again");
                                break;

                        }
                    }
                }

                else if (command == "r") 
                {
                    DisplayRegionMenu();

                    while (command != "exit")
                    {
                        command = PromptInput("Command: ");
                        switch (command)
                        {
                            case "list":
                                ListRegions();
                                break;
                            case "get":
                                GetRegion();
                                break;
                            case "add":
                                AddRegion();
                                break;
                            case "del":
                                DeleteRegion();
                                break;
                            case "exit":
                                break;
                            default:
                                Console.WriteLine("Invalid command.  Try again");
                                break;

                        }
                    }
                }
            }
            Console.WriteLine("\nHave a geat day!");
        }

        //code for customers
        private static void ListCustomers()
        {
            Console.WriteLine("\nCustomer List:");
            Console.WriteLine("============");
            //do the thing!
            List<Customer> customers = customerDb.GetCustomers();
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer);
            }

        }

        private static void GetCustomer()
        {
            Console.WriteLine("\nGet a Customer by ID:");
            Console.WriteLine("==================");
            //do the thing!
            int id = Int32.Parse(PromptInput("Customer ID: "));
            Customer c = customerDb.FindCustomer(id);
            if (c != null)
            {
                Console.WriteLine($"Customer found: {c}");
            }
            else
            {
                Console.WriteLine($"No customer found for ID {id}");
            }
        }

        private static void AddCustomer()
        {
            Console.WriteLine("\nAdd a Customer:");
            Console.WriteLine("=============");
            //do the thing!
            string name = PromptInput("Customer Name: ");

            Customer c = new Customer(name);
            customerDb.AddCustomer(c);
            Console.WriteLine($"Customer {c} has been added to the list.");
        }

        private static void DeleteCustomer()
        {
            Console.WriteLine("\nDelete a Customer by ID:");
            Console.WriteLine("======================");
            //do the thing!

            int id = Int32.Parse(PromptInput("Customer ID: "));
            Customer c = customerDb.FindCustomer(id);
            if (c != null)
            {
                customerDb.RemoveCustomer(c);
                Console.WriteLine($"Customer deleted.");
            }
            else
            {
                Console.WriteLine($"No customer found for ID {id}");
            }

        }

        static void DisplayCustomerMenu()
        {
            Console.WriteLine("MENU:");
            Console.WriteLine("============");
            Console.WriteLine("list - list all customers");
            Console.WriteLine("get - get a customer by ID");
            Console.WriteLine("add - add a customer to the list");
            Console.WriteLine("del - remove a customer from the list");
            Console.WriteLine("exit - exit application");
        }

        //code for regions
        private static void ListRegions()
        {
            Console.WriteLine("\nRegion List:");
            Console.WriteLine("============");
            //do the thing!
            List<Region> regions = regionDb.GetRegions();
            foreach (Region region in regions)
            {
                Console.WriteLine(region);
            }

        }

        private static void GetRegion()
        {
            Console.WriteLine("\nGet a Region by ID:");
            Console.WriteLine("==================");
            //do the thing!
            int id = Int32.Parse(PromptInput("Region ID: "));
            Region r = regionDb.FindRegion(id);
            if (r != null)
            {
                Console.WriteLine($"Region found: {r}");
            }
            else
            {
                Console.WriteLine($"No region found for ID {id}");
            }
        }

        private static void AddRegion()
        {
            Console.WriteLine("\nAdd a Region:");
            Console.WriteLine("=============");
            //do the thing!
            string name = PromptInput("Region Name: ");

            Region r = new Region(name);
            regionDb.AddRegion(r);
            Console.WriteLine($"Region {r} has been added to the list.");
        }

        private static void DeleteRegion()
        {
            Console.WriteLine("\nDelete a Region by ID:");
            Console.WriteLine("======================");
            //do the thing!

            int id = Int32.Parse(PromptInput("Region ID: "));
            Region r = regionDb.FindRegion(id);
            if (r != null)
            {
                regionDb.RemoveRegion(r);
                Console.WriteLine($"Region deleted.");
            }
            else
            {
                Console.WriteLine($"No region found for ID {id}");
            }

        }

        static void DisplayRegionMenu()
        {
            Console.WriteLine("MENU:");
            Console.WriteLine("============");
            Console.WriteLine("list - list all regions");
            Console.WriteLine("get - get a region by ID");
            Console.WriteLine("add - add a region to the list");
            Console.WriteLine("del - remove a region from the list");
            Console.WriteLine("exit - exit application");
        }

        //general code
        static string PromptInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine().ToLower();

        }

    }
}
