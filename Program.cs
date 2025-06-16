//Sierra Boyd
//6/7/2025
//Course Project 
//SDC320 

// Description: This is the main entry point of the application.
// It provides a simple menu-driven console interface for users 
// to manage recipes (add, edit, delete, view, and list).

using System;

class Program
{
    static void Main(string[] args)
    {

        // Instantiate the recipe manager
        Recipe recipeManager = new Recipe();

        // Infinite loop for the main menu
        while (true)
        {
            // Display menu options
            Console.WriteLine("\n****** My Cookbook *****\n");
            Console.WriteLine("1. Add Recipe");
            Console.WriteLine("2. Edit Recipe");
            Console.WriteLine("3. Delete Recipe");
            Console.WriteLine("4. Display Recipe");
            Console.WriteLine("5. List All Recipes");
            Console.WriteLine("0. Exit\n");
            Console.Write("Select an option: ");

            // Get user choice
            string choice = Console.ReadLine() ?? "";

            // Handle user selection
            switch (choice)
            {
                case "1": recipeManager.AddRecipe(); break;
                case "2":
                    Console.Write("Enter recipe ID to edit: ");
                    int editId = int.Parse(Console.ReadLine() ?? "");
                    recipeManager.EditRecipe(editId);
                    break;
                case "3":
                    Console.Write("Enter recipe ID to delete: ");
                    int delId = int.Parse(Console.ReadLine() ?? "");
                    recipeManager.DeleteRecipe(delId);
                    break;
                case "4":
                    Console.Write("Enter recipe ID to view: ");
                    int viewId = int.Parse(Console.ReadLine() ?? "");
                    recipeManager.DisplayRecipe(viewId);
                    break;
                case "5": Recipe.ListAllRecipes(); break;
                case "0": return;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }
}
