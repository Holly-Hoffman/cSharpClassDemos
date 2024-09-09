using System.Runtime.InteropServices;

namespace Homework15._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Wizard Inventory Game!\n");
            Console.WriteLine("COMMAND MENU");
            Console.WriteLine(GetMenu());

            List<string> items = new List<string>();
            items.Add("wooden staff");
            items.Add("wizard hat");
            items.Add("cloth shoes");



            string option = "";


            while (option != "exit")
            {
                Console.Write("Command: ");
                option = Console.ReadLine();
                

                switch (option)
                {
                    case "show":
                        //list items

                        for (int i = 0; i < items.Count(); i++)
                        {
                            Console.WriteLine($"{i + 1}: {items[i]}");
                        }
                        Console.WriteLine();
                        break;
                    case "grab":
                        //add item
                        Console.Write("Name: ");
                        string item = Console.ReadLine();
                        if (items.Count < 4)
                        { items.Add(item); }
                        else { Console.WriteLine("You can't carry any more items. Drop something first."); }

                        Console.WriteLine();
                        break;
                    //case "edit":
                    //    //edit existing item
                    //    int itemsNbr = GetInt("Number: ", 1, items.Count);
                    //    string oldItem = (prompt);
                    //    Console.Write("Updated name: ");
                    //    string newItem = Console.ReadLine();
                    //    stringList.ReplaceAll(oldItem, newItem);

                    case "drop":
                        //remove item
                        Console.Write("Number: ");

                        int itemsNbr = int.Parse(Console.ReadLine());
                        itemsNbr = items.Count;
                        items.RemoveAt(itemsNbr - 1);

                        Console.WriteLine("It was dropped.");
                        Console.WriteLine();
                        break;
                    case "exit":
                        //exit
                        break;
                }
                
            }

            //display a menu of options

            //1 - list names
            //2 - add name
            //3 - remove name
            //4 - exit the app

            //prompt user for option

            //perform the selection



            Console.WriteLine("Please kill me.");
        }

        private static string getString(string prompt)
        {
            Console.Write(prompt);
            string item = Console.ReadLine();
            return item;
        }

        private static string GetInt(string prompt)
        {
            string selection = "";
            Boolean isValid = false;
            while (!isValid)
            {
                try
                {
                    Console.Write(prompt);
                    selection = Console.ReadLine();
                    if (selection == "show")
                    { break; }
                    else if (selection == "grab")
                    { break; }
                    else if (selection == "edit")
                    { break; }
                    else if (selection == "drop")
                    { break; }
                    else if (selection == "exit")
                    { break; }
                    else
                    {
                        Console.WriteLine($"This is not possible!");
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid entry: please enter a valid item.");
                    continue;
                }
            }
            return selection;
        }

        private static string GetMenu()
        {
            string menu = "MENU OPTIONS:\n" + "show - Show all items\n" + "grab - Grab an item\n" + "edit - Edit an item\n" + "drop - Drop an item\n" + "exit - Exit program";
            return menu;
        }
    }
}
