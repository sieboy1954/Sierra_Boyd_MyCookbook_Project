//Sierra Boyd
//6/7/2025
//Course Project - Pt3 Class Implmentation
//SDC320 

using System;

public class RecipeFormat
{
    public void PrintRecipe(RecipeBase recipe)
    {
        Console.WriteLine($"\nRecipe Name: {recipe.Name}");
        Console.WriteLine($"Type: {recipe.Type}");
        Console.WriteLine("Ingredients:\n" + recipe.Ingredients);
        Console.WriteLine("Instructions:\n" + recipe.Instructions);
        Console.WriteLine("Date Created: " + recipe.DateCreated.ToShortDateString());
    }
}