﻿namespace LetsShopping.Domain.Models.Discount;

public class Discount : BaseClass
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal Percents { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public enum Status
    {

    }
    public DateTime ModifiedAt { get; set; }
    public DateTime DeletedAt { get; set; }
}
