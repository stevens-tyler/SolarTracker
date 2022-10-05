namespace SolarTracker.ViewModel;

[QueryProperty(nameof(User), "Monkey")]
public partial class LoginPageViewModel : BaseViewModel
{
    public LoginPageViewModel()
    {
    }

    [ObservableProperty]
    User user;
}
