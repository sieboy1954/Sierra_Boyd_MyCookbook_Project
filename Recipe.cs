//Sierra Boyd
//6/7/2025
//Course Project - Pt3 Class Implmentation
//SDC320 

using System;
using System.Collections.Generic;

public class Recipe : RecipeBase, IRecipeCRUD
{
    private RecipeFormat formatter = new RecipeFormat();
    private static List<Recipe> recipes = new List<Recipe>();
    private static int counter = 1;

    public Recipe() { }

    public Recipe(string name, string type, string ingredients, string instructions)
    {
        Id = counter++;
        Name = name;
        Type = type;
        Ingredients = ingredients;
        Instructions = instructions;
        DateCreated = DateTime.Now;
    }

    public override void Display()
    {
        formatter.PrintRecipe(this);
    }

    public void AddRecipe()
    {
        Console.Write("Enter recipe name: ");
        string name = Console.ReadLine() ?? "";
        Console.Write("Enter recipe type: ");
        string type = Console.ReadLine() ?? "";
        Console.Write("Enter ingredients (use commas or newlines): ");
        string ingredients = Console.ReadLine () ?? "";
        Console.Write("Enter instructions: ");
        string instructions = Console.ReadLine() ?? "";

        Recipe r = new Recipe(name, type, ingredients, instructions);
        recipes.Add(r);
        Console.WriteLine("Recipe added successfully!");
    }

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

    public static void ListAllRecipes()
    {
        foreach (var r in recipes)
        {
            r.Display();
            Console.WriteLine("---------------------");
        }
    }
}