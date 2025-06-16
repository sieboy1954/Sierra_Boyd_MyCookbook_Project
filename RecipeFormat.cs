//Sierra Boyd
//6/7/2025
//Course Project 
//SDC320 

// Description: This class is responsible for formatting and 
// displaying recipe data in a readable format on the console.
// It takes a RecipeBase object and prints out its details.

using System;

public class RecipeFormat
    // This method displays a formatted recipe to the console
    // Takes a RecipeBase object as a parameter
{
    public void PrintRecipe(RecipeBase recipe)
    {
        // Print the recipe name using string interpolation
        Console.WriteLine($"\nRecipe Name: {recipe.Name}");

        // Print the recipe type (e.g., Dessert, Dinner)
        Console.WriteLine($"Type: {recipe.Type}");

        // Print ingredients section
         Console.WriteLine("Ingredients:\n" + recipe.Ingredients);

        // Print instructions section
        Console.WriteLine("Instructions:\n" + recipe.Instructions);

        // Print the date the recipe was created, formatted as a short date
        Console.WriteLine("Date Created: " + recipe.DateCreated.ToShortDateString());
    }
}