using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;

namespace SolarTracker.ViewModel;

public partial class LoginPageViewModel : BaseViewModel
{

    [ObservableProperty]
    string email;

    [ObservableProperty]
    string password;

    [RelayCommand]
    void Login() 
    {
        Debug.WriteLine("DEBUG INFO: Login");
    } 
}
