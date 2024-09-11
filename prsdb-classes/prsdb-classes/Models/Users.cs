namespace prsdb_classes.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool Reviewer { get; set; }
        public bool Admin { get; set; }

        public Users(int id, string username, string password, string firstName, string lastName, string phoneNumber, string email, bool reviewer, bool admin)
        {
            Id = id;
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
            Reviewer = reviewer;
            Admin = admin;
        }

        public override string ToString()
        {
            return $"{Id}:{Username}:{Password}:{FirstName}:{LastName}:{PhoneNumber}:{Email}:{Reviewer}:{Admin}";
        }
    }
}
