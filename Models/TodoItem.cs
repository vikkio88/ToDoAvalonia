namespace Todo.Models;

using LiteDB;
public class TodoItem
{
    [BsonId]
    public ObjectId Id { get; set; }
    public string Description { get; set; } = "No Description";
    public bool isChecked { get; set; } = false;
}
