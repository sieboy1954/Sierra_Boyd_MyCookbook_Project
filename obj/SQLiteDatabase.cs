//Sierra Boyd
//6/7/2025
//Course Project
//SDC320

using System;
using System.Data.SQLite;

public class SQLiteDatabase
{
    private const string DatabaseFile = "MyCookbook.db";

    public static SQLiteConnection GetConnection()
    {
        var conn = new SQLiteConnection($"Data Source={DatabaseFile};Version=3;");
        conn.Open();
        return conn;
    }
}