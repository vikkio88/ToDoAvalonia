namespace Todo.ViewModels;
using ReactiveUI;
using System;
using System.Reactive.Linq;

using Services;

public class MainWindowViewModel : ViewModelBase
{
    ViewModelBase _content;

    public ViewModelBase Content
    { 
        get => _content;
        private set => this.RaiseAndSetIfChanged(ref _content, value);
    }

    public string Title { get; } = "Todo Main";

    public TodoListViewModel List { get; set; }

    public MainWindowViewModel()
    {
        Content = List = new TodoListViewModel(Database.Instance.GetItems());
    }

    public void AddItem()
    {
        var vm = new AddTodoViewModel();

        vm.Ok.Take(1).Subscribe(item =>
        {
            if (item is not null)
            {
                Database.Instance.AddItem(item);
                List.Items = new(Database.Instance.GetItems());
            }
            Content = List;
        });

        Content = vm;
    }

    public void Cancel()
    {
        Content = List;
    }
}

