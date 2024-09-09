using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikeLabClasses
{
    public class Products
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public string Department { get; set; }
        public bool IsElectronic { get; set; }



    }

    public class Appliance : Products
    {
        public string Room { get; set; }
    }

    public class Stove : Appliance
    {
        public bool HasRange { get; set; }
        public string OvenType { get; set; }
        public string HeatSource { get; set; }

        public Stove()
        {
            Room = "kitchen";
        }
    }

    public class Electronics : Appliance {

        public Electronics()
        {
            IsElectronic = true;
        }
        public int Wattage { get; set; }
        public bool HasInternet { get; set; }
    }
    public class TV : Electronics {
        public string Resolution { get; set; }
        public string ScreenSize { get; set; }
        bool Is4K { get; set; }
    }

    public class Computer : Electronics
    {
        public Computer() 
        {HasInternet = true;}
        public string Processor { get; set; }
        public string RAM { get; set; }
        public string GPU { get; set; }
    }

    internal class Toys : Products
    {
        public string AgeRec { get; set; }
    }
}
