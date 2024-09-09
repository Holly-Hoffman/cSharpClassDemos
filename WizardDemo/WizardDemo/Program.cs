namespace WizardDemo
{
    internal class Program
    {
        static List<string> inventory = new List<string>();
        //moved the list up to be a class so that all methods in here can access it.
        //had to make it static to match rest of methods

        static void Main(string[] args)
        {
            //NOTES:
            //need initial inventory
            inventory.Add("wooden staff");
            inventory.Add("wizard hat");
            inventory.Add("cloth shoes");
            //need to use validations - GetInt and GetString methods from other methods
            //use methods to split out biz logic into own methods, make main method more readable.

            Console.WriteLine("The Wizard Inventory Game!\n");
            Console.WriteLine("COMMAND MENU");

            //get user input
            // -display menu
            // -prompt for command (variable)
            DisplayMenu();
            string command = ("");
            // -while loop:
            while (command != "exit")
            {
                command = GetString("\nCommand: ");
                Console.WriteLine();
                // evaluate command
                //perform action
                switch (command)
                {
                    case "menu":
                        DisplayMenu();
                        break;

                    case "show":
                        ShowInventory();
                        break;

                    case "grab":
                        GrabItem();
                        break;

                    case "edit":
                        int itemNum;
                        EditItem();
                        break;

                    case "drop":
                        itemNum = DropItem();
                        break;

                    case "exit":
                        break;

                    default:
                        Console.WriteLine("Even a wizard is incapable of such actions.");
                        break;
                }
            }
            Console.WriteLine("\nThanks for playing!");
        }

        private static int DropItem()
        {
            int itemNum;
            //drop: prompt user for item number, remove item number from list, display confirmation (name)
            Console.WriteLine("Cast into the ether");
            Console.WriteLine("~*~*~*~*~*~*~*~*~*~");
            itemNum = GetInt("Item number to drop: ", 1, inventory.Count());
            string delItem = inventory[itemNum - 1];
            inventory.Remove(delItem);
            Console.WriteLine($"{delItem} was dropped into the ether.");
            return itemNum;
        }

        private static void EditItem()
        {
            //edit: prompt user for item number, prompt user for updated item name, save new name, display confirmation (number)
            Console.WriteLine("Transmuting an item");
            Console.WriteLine("~*~*~*~*~*~*~*~*~*~");
            int itemNum = GetInt("Item number to transmute: ", 1, inventory.Count());
            string updatedName = GetString("Updated item name: ");
            inventory[itemNum - 1] = updatedName;
            Console.WriteLine($"Item number {itemNum} was transmuted into {updatedName}.");
        }

        private static void GrabItem()
        {
            //grab: add an item (limit # of items to 4)
            Console.WriteLine("Grabbing from the ether");
            Console.WriteLine("~*~*~*~*~*~*~*~*~*~");
            if (inventory.Count() >= 4)
            {
                Console.WriteLine("Your satchel overfloweth. An item must first be cast into the ether.");
            }
            else
            {
                string newItem = GetString("New item name: ");
                inventory.Add(newItem);
                Console.WriteLine($"{newItem} was added.");
            }
        }

        private static void ShowInventory()
        {
            Console.WriteLine("Current Inventory");
            Console.WriteLine("~*~*~*~*~*~*~*~*~*~");
            for (int i = 0; i < inventory.Count(); i++)
            {
                Console.WriteLine($"{i + 1}. {inventory[i]}");
            }
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("MENU OPTIONS:\n" +
                "menu - Display menu\n" +
                "show - Show all items\n" +
                "grab - Grab an item\n" +
                "edit - Edit an item\n" +
                "drop - Drop an item\n" +
                "exit - Exit program");
        }

        //GetInt - checking when user has to enter ints
        private static int GetInt(string prompt, int min, int max)
        {
            int number = 0;
            Boolean isValid = false;

            while (!isValid)
            {
                try
                {
                    Console.Write(prompt);
                    number = int.Parse(Console.ReadLine());
                    if (number < min)
                    {
                        Console.WriteLine($"Invalid entry: number must be greater than {min}.");
                        continue;
                    }
                    else if (number > max)
                    {
                        Console.WriteLine($"Invalid entry: number must be less than {max}.");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid entry: please enter a valid number.");
                    continue;
                }
            }

            return number;
        }


        //GetString: used to grab info from user
        private static string GetString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine().ToLower();
        }
    }
}
