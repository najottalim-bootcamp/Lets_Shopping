﻿namespace LetsShopping.Domain.Models.Discount;

public class Discount : BaseClass
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int DiscountPercent { get; set; }
    public bool Active { get; set; }
    public DateTime DeletedAt { get; set; }
}
