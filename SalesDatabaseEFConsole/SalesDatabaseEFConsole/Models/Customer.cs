using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace SalesDatabaseEFConsole.Models;

[Table("Customer")]
[Index("Name", Name = "UQ_Customer_Name", IsUnique = true)]
public partial class Customer
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [InverseProperty("Customer")]
    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();

    //constructors
    public Customer(string name)
    { 
        Name = name;
    }

    public override string ToString()
    {
        return $"Customer: {Name}";
    }

}
