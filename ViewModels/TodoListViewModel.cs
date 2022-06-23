namespace Todo.ViewModels;

using System.Collections.Generic;
using System.Collections.ObjectModel;
using Todo.Models;
public class TodoListViewModel : ViewModelBase
{
    public ObservableCollection<TodoItem> Items { get; set; }
    public TodoListViewModel(IEnumerable<TodoItem> items)
    {
        Items = new(items);
    }
}
