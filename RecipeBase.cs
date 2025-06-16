//Sierra Boyd
//6/7/2025
//Course Project 
//SDC320 

// Description: Abstract base class for recipes.
// It defines shared properties (Id, Name, etc.) and enforces 
// the implementation of the Display method in derived classes.

using System;

public abstract class RecipeBase
{
     // Unique identifier for the recipe
    public int Id { get; set; }

    // Title of the recipe
    public string? Name { get; set; }

    // Category or type of the recipe (e.g., Dessert, Appetizer)
    public string? Type { get; set; }

    // List of ingredients required for the recipe
    public string? Ingredients { get; set; }

    // Cooking or preparation instructions
    public string? Instructions { get; set; }

    // Date the recipe was created
    public DateTime DateCreated { get; set; }

    // Abstract method for displaying the recipe.
    // Must be implemented in any derived class (e.g., Recipe.cs)
    public abstract void Display();
}