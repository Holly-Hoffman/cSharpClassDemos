﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace EFprsDB.Models;

[Table("Request")]
[Index("RequestNumber", Name = "UQ_Req_Num", IsUnique = true)]
public partial class Request
{
    [Key]
    public int Id { get; set; }

    public int UserId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string RequestNumber { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string Justification { get; set; } = null!;

    public DateOnly? DateNeeded { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string DeliveryMode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string Status { get; set; } = null!;

    [Column(TypeName = "decimal(10, 2)")]
    public decimal Total { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SubmittedDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ReasonForRejection { get; set; }

    [InverseProperty("Request")]
    public virtual ICollection<LineItem> LineItems { get; set; } = new List<LineItem>();

    [ForeignKey("UserId")]
    [InverseProperty("Requests")]
    public virtual User User { get; set; } = null!;

    //constructors
    public Request(int userId, string requestNumber, string description, string justification, DateOnly dateNeeded,
        string deliveryMode, string status, decimal total, DateTime submittedDate, string reasonForRejection)
    {
        UserId = userId;
        RequestNumber = requestNumber;
        Description = description;
        Justification = justification;
        DateNeeded = dateNeeded;
        DeliveryMode = deliveryMode;
        Status = status;
        Total = total;
        SubmittedDate = submittedDate;
        ReasonForRejection = reasonForRejection;
    }

    public override string ToString()
    {
        return $"Request: {UserId}, {RequestNumber}, {Description}, {Justification}, {DateNeeded}, {DeliveryMode}, {Status}, {Total}, {SubmittedDate}, {ReasonForRejection}";
    }

}
