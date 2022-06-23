namespace Todo.ViewModels;

using ReactiveUI;
using System.Reactive;

public class AddTodoViewModel : ViewModelBase
{
    public string Title { get; } = "Todo List -> Add New Item";
    private string _description;
    public string Description { get => _description; set => this.RaiseAndSetIfChanged(ref _description, value); }

    public ReactiveCommand<Unit, Models.TodoItem> Ok { get; set; }
    public AddTodoViewModel()
    {
        var okEnabled = this.WhenAnyValue(
            x => x.Description,
            x => !string.IsNullOrWhiteSpace(x)
        );
        Ok = ReactiveCommand.Create(() => new Models.TodoItem { Description = Description }, okEnabled);
    }
}
