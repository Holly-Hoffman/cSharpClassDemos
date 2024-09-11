namespace prsdb_classes.Models
{
    public class Vendor
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Vendor(int id, string code, string name, string address, string city, string state, string postalCode, string phoneNumber, string email)
        {
            Id = id;
            Code = code;
            Name = name;
            Address = address;
            City = city;
            State = state;
            PostalCode = postalCode;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        public override string ToString()
        {
            return $"{Id}:{Code}:{Name}:{Address}:{City}:{State}:{PostalCode}:{PhoneNumber}:{Email}";
        }
    }
}
