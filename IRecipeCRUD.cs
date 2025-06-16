//Sierra Boyd
//6/7/2025
//Course Project 
//SDC320 

// Description: Interface defining basic CRUD operations for recipes.
// Any class that implements this interface must provide implementations
// for adding, editing, deleting, and displaying recipes by ID.

public interface IRecipeCRUD
{
     // Adds a new recipe to the system
    void AddRecipe();

     // Edits an existing recipe using its ID
    void EditRecipe(int id);

    // Deletes a recipe from the system by ID
    void DeleteRecipe(int id);

    // Displays a specific recipe by ID
    void DisplayRecipe(int id);
}