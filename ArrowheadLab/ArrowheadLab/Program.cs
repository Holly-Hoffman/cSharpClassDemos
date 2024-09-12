namespace ArrowheadLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrowHeight = GetInt("How tall should the arrowhead be? ", 1, int.MaxValue);
            if (arrowHeight % 2 != 0)
            {
                arrowHeight = arrowHeight + 1;
            }

            string arrowHead = "";

            for (int i = 0; i < arrowHeight; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    Console.Write(">");
                }
                Console.WriteLine();
            }
            for (int i = arrowHeight; i > 0; i--)
            { for (int j = 0; j < i; j++)
                {
                    Console.Write(">");
                }
            Console.WriteLine();
                        

            }


        }


        static int GetInt(string prompt, int min, int max)
        {
            int arrowHeight = 0;
            Boolean isValid = false;

            while (!isValid)
            {
                try
                {
                    Console.Write(prompt);
                    arrowHeight = int.Parse(Console.ReadLine());
                    if (arrowHeight < min)
                    {
                        Console.WriteLine($"Invalid entry: number must be greater than {min}.");
                        continue;
                    }
                    else if (arrowHeight > max)
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

            return arrowHeight;
        }

    }

}

