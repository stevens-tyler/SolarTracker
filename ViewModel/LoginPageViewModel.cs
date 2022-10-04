using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;
using SolarTracker.Model;

namespace SolarTracker.ViewModel;

[QueryProperty("User","User")]
public partial class LoginPageViewModel : BaseViewModel
{
    public LoginPageViewModel()
    {

    }

    [ObservableProperty]
    User user;
}
