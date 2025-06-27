using CommunityToolkit.Mvvm.Input;
using MapSecret.Models;

namespace MapSecret.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}