using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace EFprsDB.Models;

[Table("LineItem")]
[Index("RequestId", "ProductId", Name = "UQ_Product_Request", IsUnique = true)]
public partial class LineItem
{
    [Key]
    public int Id { get; set; }

    public int RequestId { get; set; }

    [Column("ProductID")]
    public int ProductId { get; set; }

    public int Quantity { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("LineItems")]
    public virtual Product Product { get; set; } = null!;

    [ForeignKey("RequestId")]
    [InverseProperty("LineItems")]
    public virtual Request Request { get; set; } = null!;

    //constructors
    public LineItem(int requestId, int productId, int quantity)
    {
        this.RequestId = requestId;
        this.ProductId = productId;
        this.Quantity = quantity;
    }

    public override string ToString()
    {
        return $"Line Item: {RequestId}, {ProductId}, {Quantity}";
    }

}
