namespace prsdb_classes.Models
{
    public class Products
    {
        public int Id { get; set; }
        public int VendorId { get; set; }
        public string PartNumber { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }
        public string PhotoPath { get; set; }

        public Products(int id, int vendorId, string partNumber, string name, decimal price, string unit, string photoPath)
        {
            Id = id;
            VendorId = vendorId;
            PartNumber = partNumber;
            Name = name;
            Price = price;
            Unit = unit;
            PhotoPath = photoPath;
        }
        public override string ToString()
        {
            return $"{Id}:{VendorId}:{PartNumber}:{Name}:{Price}:{Unit}:{PhotoPath}";
        }
    }
}
