using Microsoft.VisualBasic;
using System.Reflection.Emit;

namespace MikeLabClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product List");
            Stove dunnoStoveNames = new();
            dunnoStoveNames.ProductName = "Dunno KPV 50043";
            dunnoStoveNames.ProductDescription = "Medium Stove, 2 racks";
            dunnoStoveNames.Price = 10000M;
            dunnoStoveNames.IsElectronic = true;
            dunnoStoveNames.HasRange = true;
            dunnoStoveNames.OvenType = "Convection combo";
            dunnoStoveNames.HeatSource = "Gas";

            PrintLabel(dunnoStoveNames);
        }

        static public void PrintLabel(Products label)
        {
            Console.WriteLine($"{ label.ProductName} : { label.Price}");
        }
    }
}
