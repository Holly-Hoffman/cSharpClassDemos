using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace EFprsDB.Models;

[Index("VendorId", "PartNumber", Name = "UQ_Vendor_Part", IsUnique = true)]
public partial class Product
{
    [Key]
    public int Id { get; set; }

    public int VendorId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PartNumber { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [Column(TypeName = "decimal(10, 2)")]
    public decimal Price { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Unit { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? PhotoPath { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<LineItem> LineItems { get; set; } = new List<LineItem>();

    [ForeignKey("VendorId")]
    [InverseProperty("Products")]
    public virtual Vendor Vendor { get; set; } = null!;

    //constructors
    public Product(int vendorId, string partNumber, string name, decimal price, string unit, string photoPath)
    {
        this.VendorId = vendorId;
        this.PartNumber = partNumber;
        this.Name = name;
        this.Price = price;
        this.Unit = unit;
        this.PhotoPath = photoPath;
    }

    public override string ToString()
    {
        return $"Product: {VendorId}, {PartNumber}, {Name}, {Price}, {Unit}, {PhotoPath}";
    }

}
