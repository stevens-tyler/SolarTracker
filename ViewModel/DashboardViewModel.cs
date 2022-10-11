namespace SolarTracker.ViewModel;

[QueryProperty(nameof(User), "User")]
public partial class DashboardViewModel : BaseViewModel
{
    public DashboardViewModel()
    {
    }

    [ObservableProperty]
    User user;
}
