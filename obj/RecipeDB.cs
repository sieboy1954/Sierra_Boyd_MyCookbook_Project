//Sierra Boyd
//6/7/2025
//Course Project
//SDC320

using System;
using System.Collections.Generic;
using System.Data.SQLite;

public static class RecipeDB
{
    public static void InitializeTable()
    {
        using var conn = SQLiteDatabase.GetConnection();
        string sql = @"CREATE TABLE IF NOT EXISTS Recipes (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            Name TEXT,
            Type TEXT,
            Ingredients TEXT,
            Instructions TEXT,
            DateCreated TEXT);";
        using var cmd = new SQLiteCommand(sql, conn);
        cmd.ExecuteNonQuery();
    }

    public static void Add(Recipe recipe)
    {
        using var conn = SQLiteDatabase.GetConnection();
        string sql = @"INSERT INTO Recipes (Name, Type, Ingredients, Instructions, DateCreated)
                      VALUES (@name, @type, @ingredients, @instructions, @dateCreated)";
        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@name", recipe.Name);
        cmd.Parameters.AddWithValue("@type", recipe.Type);
        cmd.Parameters.AddWithValue("@ingredients", recipe.Ingredients);
        cmd.Parameters.AddWithValue("@instructions", recipe.Instructions);
        cmd.Parameters.AddWithValue("@dateCreated", recipe.DateCreated.ToString("yyyy-MM-dd"));
        cmd.ExecuteNonQuery();
    }

    public static List<Recipe> GetAll()
    {
        var recipes = new List<Recipe>();
        using var conn = SQLiteDatabase.GetConnection();
        string sql = "SELECT * FROM Recipes";
        using var cmd = new SQLiteCommand(sql, conn);
        using var rdr = cmd.ExecuteReader();

        while (rdr.Read())
        {
            recipes.Add(new Recipe
            {
                Id = rdr.GetInt32(0),
                Name = rdr.GetString(1),
                Type = rdr.GetString(2),
                Ingredients = rdr.GetString(3),
                Instructions = rdr.GetString(4),
                DateCreated = DateTime.Parse(rdr.GetString(5))
            });
        }
        return recipes;
    }

    public static Recipe? GetById(int id)
    {
        using var conn = SQLiteDatabase.GetConnection();
        string sql = "SELECT * FROM Recipes WHERE Id = @id";
        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@id", id);
        using var rdr = cmd.ExecuteReader();
        if (rdr.Read())
        {
            return new Recipe
            {
                Id = rdr.GetInt32(0),
                Name = rdr.GetString(1),
                Type = rdr.GetString(2),
                Ingredients = rdr.GetString(3),
                Instructions = rdr.GetString(4),
                DateCreated = DateTime.Parse(rdr.GetString(5))
            };
        }
        return null;
    }

    public static void Update(Recipe recipe)
    {
        using var conn = SQLiteDatabase.GetConnection();
        string sql = @"UPDATE Recipes SET
                        Name = @name,
                        Type = @type,
                        Ingredients = @ingredients,
                        Instructions = @instructions
                      WHERE Id = @id";
        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@name", recipe.Name);
        cmd.Parameters.AddWithValue("@type", recipe.Type);
        cmd.Parameters.AddWithValue("@ingredients", recipe.Ingredients);
        cmd.Parameters.AddWithValue("@instructions", recipe.Instructions);
        cmd.Parameters.AddWithValue("@id", recipe.Id);
        cmd.ExecuteNonQuery();
    }

    public static void Delete(int id)
    {
        using var conn = SQLiteDatabase.GetConnection();
        string sql = "DELETE FROM Recipes WHERE Id = @id";
        using var cmd = new SQLiteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.ExecuteNonQuery();
    }
}
