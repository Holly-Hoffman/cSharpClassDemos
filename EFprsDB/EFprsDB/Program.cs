using EFprsDB.Db;
using EFprsDB.Models;

namespace EFprsDB
{
    internal class Program
    {
        static LineItemDb lineItemDb = new LineItemDb();
        static ProductDb productDb = new ProductDb();
        static RequestDb requestDb = new RequestDb();
        static UserDb userDb = new UserDb();
        static VendorDb vendorDb = new VendorDb();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Entity Framework, the PRS Manager!\n");
            Console.WriteLine("Please type EXIT at any time to exit the program.\n");
            string command = "";
            command = PromptInput("Would you like to interact with\n- Line item data (L)\n- Product data (P):" +
                "\n- Request data (R)\n- User data (U)\n- Vendor data (V)\n");

            while (command != "exit")
            {

                if (command == "l")
                {
                    DisplayLineItemMenu();

                    while (command != "exit")
                    {
                        command = PromptInput("Command: ");
                        switch (command)
                        {
                            case "list":
                                ListLineItems();
                                break;
                            case "get":
                                GetLineItem();
                                break;
                            case "add":
                                AddLineItem();
                                break;
                            case "del":
                                DeleteLineItem();
                                break;
                            case "exit":
                                break;
                            default:
                                Console.WriteLine("Invalid command. Try again.");
                                break;
                        }

                    }
                }

                else if (command == "p")
                {
                    DisplayProductMenu();

                    while (command != "exit")
                    {
                        command = PromptInput("Command: ");
                        switch (command)
                        {
                            case "list":
                                ListProducts();
                                break;
                            case "get":
                                GetProduct();
                                break;
                            case "add":
                                AddProduct();
                                break;
                            case "del":
                                DeleteProduct();
                                break;
                            case "exit":
                                break;
                            default:
                                Console.WriteLine("Invalid command. Try again.");
                                break;
                        }

                    }
                }

                else if (command == "r")
                {
                    DisplayRequestMenu();

                    while (command != "exit")
                    {
                        command = PromptInput("Command: ");
                        switch (command)
                        {
                            case "list":
                                ListRequests();
                                break;
                            case "get":
                                GetRequest();
                                break;
                            case "add":
                                AddRequest();
                                break;
                            case "del":
                                DeleteRequest();
                                break;
                            case "exit":
                                break;
                            default:
                                Console.WriteLine("Invalid command. Try again.");
                                break;
                        }

                    }
                }

                else if (command == "v")
                {
                    DisplayVendorMenu();

                    while (command != "exit")
                    {
                        command = PromptInput("Command: ");
                        switch (command)
                        {
                            case "list":
                                ListVendors();
                                break;
                            case "get":
                                GetVendor();
                                break;
                            case "add":
                                AddVendor();
                                break;
                            case "del":
                                DeleteVendor();
                                break;
                            case "exit":
                                break;
                            default:
                                Console.WriteLine("Invalid command. Try again.");
                                break;
                        }

                    }
                }

                else if (command == "u")
                {
                    DisplayUserMenu();

                    while (command != "exit")
                    {
                        command = PromptInput("Command: ");
                        switch (command)
                        {
                            case "list":
                                ListUsers();
                                break;
                            case "get":
                                GetUser();
                                break;
                            case "add":
                                AddUser();
                                break;
                            case "del":
                                DeleteUser();
                                break;
                            case "exit":
                                break;
                            default:
                                Console.WriteLine("Invalid command. Try again.");
                                break;
                        }

                    }
                }

                else { Console.WriteLine("Invalid command."); }

            }
            Console.WriteLine("Bye!");
        }


        //code for products
        private static void ListProducts()
        {
            Console.WriteLine("\nProducts List:");
            Console.WriteLine("============");
            //do the thing!
            List<Product> products = productDb.GetProducts();
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }

        }

        private static void GetProduct()
        {
            Console.WriteLine("\nGet an Product by ID:");
            Console.WriteLine("==================");
            //do the thing!
            int id = Int32.Parse(PromptInput("Product ID: "));
            Product p = productDb.FindProduct(id);
            if (p != null)
            {
                Console.WriteLine($"Product found: {p}");
            }
            else
            {
                Console.WriteLine($"No product found for ID {id}");
            }
        }

        private static void AddProduct()
        {
            Console.WriteLine("\nAdd an Product:");
            Console.WriteLine("=============");
            //do the thing!
            int vendorID = Int32.Parse(PromptInput("Vendor ID #: "));
            string partNumber = PromptInput("Part Number: ");
            string name = PromptInput("Name: ");
            decimal price = Decimal.Parse(PromptInput("Price per Unit: "));
            string unit = PromptInput("Unit name: ");
            string photoPath = PromptInput("PhotoPath: ");
            Product p = new Product(vendorID, partNumber, name, price, unit, photoPath);
            productDb.AddProduct(p);
            Console.WriteLine($"Product {p} has been added to the list.");
        }

        private static void DeleteProduct()
        {
            Console.WriteLine("\nDelete an Product by ID:");
            Console.WriteLine("======================");
            //do the thing!

            int id = Int32.Parse(PromptInput("LineItem ID: "));
            Product p = productDb.FindProduct(id);
            if (p != null)
            {
                productDb.RemoveProduct(p);
                Console.WriteLine($"Product deleted.");
            }
            else
            {
                Console.WriteLine($"No product found for ID {id}");
            }

        }

        static void DisplayProductMenu()
        {
            Console.WriteLine("MENU:");
            Console.WriteLine("============");
            Console.WriteLine("list - list all products");
            Console.WriteLine("get - get a product by ID");
            Console.WriteLine("add - add a product to the list");
            Console.WriteLine("del - remove a product from the list");
            Console.WriteLine("exit - exit application");
        }

        //code for requests
        private static void ListRequests()
        {
            Console.WriteLine("\nRequests List:");
            Console.WriteLine("============");
            //do the thing!
            List<Request> requests = requestDb.GetRequests();
            foreach (Request request in requests)
            {
                Console.WriteLine(request);
            }

        }

        private static void GetRequest()
        {
            Console.WriteLine("\nGet a Request by ID:");
            Console.WriteLine("==================");
            //do the thing!
            int id = Int32.Parse(PromptInput("Request ID: "));
            Request r = requestDb.FindRequest(id);
            if (r != null)
            {
                Console.WriteLine($"Request found: {r}");
            }
            else
            {
                Console.WriteLine($"No request found for ID {id}");
            }
        }

        private static void AddRequest()
        {
            Console.WriteLine("\nAdd a Request:");
            Console.WriteLine("=============");
            //do the thing!
            int userID = Int32.Parse(PromptInput("User ID #: "));
            string requestNumber = PromptInput("Request Number: ");
            string description = PromptInput("Description: ");
            string justification = PromptInput("Justification: ");
            DateOnly dateNeeded = DateOnly.Parse(PromptInput("Date Needed: "));
            string deliveryMode = PromptInput("Delivery Mode: ");
            string status = PromptInput("Status: ");
            decimal total = decimal.Parse(PromptInput("Total Price: "));
            DateTime submittedDate = DateTime.Parse(PromptInput("Date Submitted: "));
            string reasonForRejection = PromptInput("Reason for Rejection: ");
            Request r = new Request(userID, requestNumber, description, justification, dateNeeded, deliveryMode, status, total, submittedDate, reasonForRejection);
            requestDb.AddRequest(r);
            Console.WriteLine($"Request {r} has been added to the list.");
        }

        private static void DeleteRequest()
        {
            Console.WriteLine("\nDelete a Request by ID:");
            Console.WriteLine("======================");
            //do the thing!

            int id = Int32.Parse(PromptInput("Request ID: "));
            Request r = requestDb.FindRequest(id);
            if (r != null)
            {
                requestDb.RemoveRequest(r);
                Console.WriteLine($"Request deleted.");
            }
            else
            {
                Console.WriteLine($"No request found for ID {id}");
            }

        }

        static void DisplayRequestMenu()
        {
            Console.WriteLine("MENU:");
            Console.WriteLine("============");
            Console.WriteLine("list - list all requests");
            Console.WriteLine("get - get a request by ID");
            Console.WriteLine("add - add a request to the list");
            Console.WriteLine("del - remove a request from the list");
            Console.WriteLine("exit - exit application");
        }

        //code for lineItems
        private static void ListLineItems()
        {
            Console.WriteLine("\nLineItems List:");
            Console.WriteLine("============");
            //do the thing!
            List<LineItem> lineItems = lineItemDb.GetLineItems();
            foreach (LineItem lineItem in lineItems)
            {
                Console.WriteLine(lineItem);
            }

        }

        private static void GetLineItem()
        {
            Console.WriteLine("\nGet a LineItem by ID:");
            Console.WriteLine("==================");
            //do the thing!
            int id = Int32.Parse(PromptInput("LineItem ID: "));
            LineItem l = lineItemDb.FindLineItem(id);
            if (l != null)
            {
                Console.WriteLine($"LineItem found: {l}");
            }
            else
            {
                Console.WriteLine($"No lineItem found for ID {id}");
            }
        }

        private static void AddLineItem()
        {
            Console.WriteLine("\nAdd a LineItem:");
            Console.WriteLine("=============");
            //do the thing!
            int requestId = Int32.Parse(PromptInput("Request ID #: "));
            int productId = Int32.Parse(PromptInput("Product ID #: "));
            int quantity = Int32.Parse(PromptInput("Quantity: "));
            LineItem l = new LineItem(requestId, productId, quantity);
            lineItemDb.AddLineItem(l);
            Console.WriteLine($"LineItem {l} has been added to the list.");
        }

        private static void DeleteLineItem()
        {
            Console.WriteLine("\nDelete a LineItem by ID:");
            Console.WriteLine("======================");
            //do the thing!

            int id = Int32.Parse(PromptInput("LineItem ID: "));
            LineItem l = lineItemDb.FindLineItem(id);
            if (l != null)
            {
                lineItemDb.RemoveLineItem(l);
                Console.WriteLine($"LineItem deleted.");
            }
            else
            {
                Console.WriteLine($"No lineItem found for ID {id}");
            }

        }

        static void DisplayLineItemMenu()
        {
            Console.WriteLine("MENU:");
            Console.WriteLine("============");
            Console.WriteLine("list - list all Line Items");
            Console.WriteLine("get - get a Line Item by ID");
            Console.WriteLine("add - add a Line Item to the list");
            Console.WriteLine("del - remove a Line Item from the list");
            Console.WriteLine("exit - exit application");
        }

        //code for users
        private static void ListUsers()
        {
            Console.WriteLine("\nUsers List:");
            Console.WriteLine("============");
            //do the thing!
            List<User> users = userDb.GetUsers();
            foreach (User user in users)
            {
                Console.WriteLine(user);
            }

        }

        private static void GetUser()
        {
            Console.WriteLine("\nGet a User by ID:");
            Console.WriteLine("==================");
            //do the thing!
            int id = Int32.Parse(PromptInput("User ID: "));
            User u = userDb.FindUser(id);
            if (u != null)
            {
                Console.WriteLine($"User found: {u}");
            }
            else
            {
                Console.WriteLine($"No user found for ID {id}");
            }
        }

        private static void AddUser()
        {
            Console.WriteLine("\nAdd a User:");
            Console.WriteLine("=============");
            //do the thing!
            string username = PromptInput("Username: ");
            string password = PromptInput("Password: ");
            string firstName = PromptInput("First name: ");
            string lastName = PromptInput("Last name: ");
            string phoneNumber = PromptInput("Phone number: ");
            string email = PromptInput("Email: ");
            bool reviewer = bool.Parse(PromptInput("User is a reviewer? (true/false): "));
            bool admin = bool.Parse(PromptInput("User is an admin? (true/false): "));
            User u = new User(username, password, firstName, lastName, phoneNumber, email, reviewer, admin);
            userDb.AddUser(u);
            Console.WriteLine($"User {u} has been added to the list.");
        }

        private static void DeleteUser()
        {
            Console.WriteLine("\nDelete a User by ID:");
            Console.WriteLine("======================");
            //do the thing!

            int id = Int32.Parse(PromptInput("User ID: "));
            User u = userDb.FindUser(id);
            if (u != null)
            {
                userDb.RemoveUser(u);
                Console.WriteLine($"User deleted.");
            }
            else
            {
                Console.WriteLine($"No user found for ID {id}");
            }

        }

        static void DisplayUserMenu()
        {
            Console.WriteLine("MENU:");
            Console.WriteLine("============");
            Console.WriteLine("list - list all Users");
            Console.WriteLine("get - get a User by ID");
            Console.WriteLine("add - add a User to the list");
            Console.WriteLine("del - remove a User from the list");
            Console.WriteLine("exit - exit application");
        }

        //code for vendors
        private static void ListVendors()
        {
            Console.WriteLine("\nVendor List:");
            Console.WriteLine("============");
            //do the thing!
            List<Vendor> vendors = vendorDb.GetVendors();
            foreach (Vendor vendor in vendors)
            {
                Console.WriteLine(vendor);
            }

        }

        private static void GetVendor()
        {
            Console.WriteLine("\nGet a Vendor by ID:");
            Console.WriteLine("==================");
            //do the thing!
            int id = Int32.Parse(PromptInput("Vendor ID: "));
            Vendor v = vendorDb.FindVendor(id);
            if (v != null)
            {
                Console.WriteLine($"Vendor found: {v}");
            }
            else
            {
                Console.WriteLine($"No vendor found for ID {id}");
            }
        }

        private static void AddVendor()
        {
            Console.WriteLine("\nAdd a Vendor:");
            Console.WriteLine("=============");
            //do the thing!
            string code = PromptInput("Vendor Code: ");
            string name = PromptInput("Vendor Name: ");
            string address = PromptInput("Street Address: ");
            string city = PromptInput("City: ");
            string state = PromptInput("State: ");
            string zip = PromptInput("Zip: ");
            string phoneNumber = PromptInput("Phone Number: ");
            string email = PromptInput("Email: ");
            Vendor v = new Vendor(code, name, address, city, state, zip, phoneNumber, email);
            vendorDb.AddVendor(v);
            Console.WriteLine($"Vendor {v} has been added to the list.");
        }

        private static void DeleteVendor()
        {
            Console.WriteLine("\nDelete a Vendor by ID:");
            Console.WriteLine("======================");
            //do the thing!

            int id = Int32.Parse(PromptInput("Vendor ID: "));
            Vendor v = vendorDb.FindVendor(id);
            if (v != null)
            {
                vendorDb.RemoveVendor(v);
                Console.WriteLine($"Vendor deleted.");
            }
            else
            {
                Console.WriteLine($"No vendor found for ID {id}");
            }

        }

        static void DisplayVendorMenu()
        {
            Console.WriteLine("MENU:");
            Console.WriteLine("============");
            Console.WriteLine("list - list all vendors");
            Console.WriteLine("get - get a vendor by ID");
            Console.WriteLine("add - add a vendor to the list");
            Console.WriteLine("del - remove a vendor from the list");
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
