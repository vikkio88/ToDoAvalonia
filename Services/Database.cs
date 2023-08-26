namespace Todo.Services;

using System.Collections.Generic;
using Todo.Models;
using LiteDB;

public class Database : Singleton<Database>
{
    private ILiteDatabase _db;

    public Database()
    {
        _db = new LiteDatabase("Test.db");
    }

    public IEnumerable<TodoItem> GetItems() => _db.GetCollection<TodoItem>("todos").FindAll();
    public void AddItem(TodoItem item) => _db.GetCollection<TodoItem>("todos").Insert(item);
}
