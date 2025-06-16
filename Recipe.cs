//Sierra Boyd
//6/7/2025
//Course Project 
//SDC320 

 //Description: This class represents a Recipe object and includes 
// functionality for adding, editing, deleting, and displaying recipes. 
// It implements IRecipeCRUD and inherits from RecipeBase.

using System;
using System.Collections.Generic;

public class Recipe : RecipeBase, IRecipeCRUD
{
    // Formatter object to display recipe nicely
    private RecipeFormat formatter = new RecipeFormat();

     // Static list to hold all recipe instances
    private static List<Recipe> recipes = new List<Recipe>();

    // Static counter to auto-generate recipe IDs
    private static int counter = 1;

    // Default constructor 
    public Recipe() { }

// Overloaded constructor to set initial values
    public Recipe(string name, string type, string ingredients, string instructions)
    {
        Id = counter++; // Auto-increment ID
        Name = name;
        Type = type;
        Ingredients = ingredients;
        Instructions = instructions;
        DateCreated = DateTime.Now;
    }

// Display method using the RecipeFormat class
    public override void Display()
    {
        formatter.PrintRecipe(this);
    }


// Prompts user to input recipe details and adds to list
    public void AddRecipe()
    {
        Console.Write("Enter recipe name: ");
        string name = Console.ReadLine() ?? "";
        Console.Write("Enter recipe type: ");
        string type = Console.ReadLine() ?? "";
        Console.Write("Enter ingredients (use commas or newlines): ");
        string ingredients = Console.ReadLine() ?? "";
        Console.Write("Enter instructions: ");
        string instructions = Console.ReadLine() ?? "";

        Recipe r = new Recipe(name, type, ingredients, instructions);
        recipes.Add(r);
        Console.WriteLine("Recipe added successfully!");
    }
// Edit a recipe by its ID
    public void EditRecipe(int id)
    {
        var recipe = recipes.Find(r => r.Id == id);
        if (recipe != null)
        {
            Console.Write("Enter new name: "); recipe.Name = Console.ReadLine();
            Console.Write("Enter new type: "); recipe.Type = Console.ReadLine();
            Console.Write("Enter new ingredients: "); recipe.Ingredients = Console.ReadLine();
            Console.Write("Enter new instructions: "); recipe.Instructions = Console.ReadLine();
            Console.WriteLine("Recipe updated.");
        }
        else
        {
            Console.WriteLine("Recipe not found.");
        }
    }
 // Delete a recipe by its ID
    public void DeleteRecipe(int id)
    {
        var recipe = recipes.Find(r => r.Id == id);
        if (recipe != null)
        {
            recipes.Remove(recipe);
            Console.WriteLine("Recipe deleted.");
        }
        else
        {
            Console.WriteLine("Recipe not found.");
        }
    }
  // Display a single recipe by its ID
    public void DisplayRecipe(int id)
    {
        var recipe = recipes.Find(r => r.Id == id);
        if (recipe != null)
        {
            recipe.Display();
        }
        else
        {
            Console.WriteLine("Recipe not found.");
        }
    }
    // Display all recipes in the list
    public static void ListAllRecipes()
    {
        foreach (var r in recipes)
        {
            r.Display();
            Console.WriteLine("---------------------");
        }
    }
}