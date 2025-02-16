﻿using MarketWorld.Domain.Entities;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public ICollection<Product> Products { get; set; }
}