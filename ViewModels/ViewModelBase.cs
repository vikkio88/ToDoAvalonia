using ReactiveUI;

namespace Todo.ViewModels
{
    public class ViewModelBase : ReactiveObject
    {
        public string Title { get; } =  "Todo List";
    }
}
