//Sierra Boyd
//6/7/2025
//Course Project - Pt3 Class Implmentation
//SDC320 

using System;

public abstract class RecipeBase
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }
    public string? Ingredients { get; set; }
    public string? Instructions { get; set; }
    public DateTime DateCreated { get; set; }

    public abstract void Display();
}