using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ch20EFbmdbConsole.Models;

[Table("Actor")]
[Index("FirstName", "LastName", "Birthdate", Name = "UQ_Actor_Name_bd", IsUnique = true)]
public partial class Actor
{
    [Key]
    public int Id { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string FirstName { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string LastName { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string Gender { get; set; } = null!;

    public DateOnly Birthdate { get; set; }

    [InverseProperty("Actor")]
    public virtual ICollection<Credit> Credits { get; set; } = new List<Credit>();

    //constructors
    public Actor(string firstName, string lastName, string gender, DateOnly birthdate)
    {
        FirstName = firstName;
        LastName = lastName;
        Gender = gender;
        Birthdate = birthdate;
    }

    public override string ToString()
    {
        return $"Actor: {FirstName}, {LastName}, {Gender}, {Birthdate}";
    }
}
