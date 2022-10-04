using SolarTracker.Model;
using SolarTracker.Services;
using System.Diagnostics;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using SolarTracker.View;

namespace SolarTracker.ViewModel;

public partial class UserViewModel : BaseViewModel
{

    UserService userService;

    public ObservableCollection<User> Users { get; }  = new();

    public UserViewModel(UserService userService) 
    {
        Title = "User Page";
        this.userService = userService;
        
    }
    [RelayCommand]
    async Task GoToLoginPageCommand(User user)
    {
        Debug.WriteLine("DEBUG INFO: GoToLoginPageCommand");

        if (user is null)
            return;

        await Shell.Current.GoToAsync(nameof(LoginPage), true, new Dictionary<string, object>
    {
        {"User", user }
    });
    }
    
    [RelayCommand]
    async Task GetUserAsync()
    {

        Debug.WriteLine("DEBUG INFO: GetUserAsync");

        if (IsBusy)
            return;

        try
        {
            IsBusy = true;
            var accounts = await userService.GetUsers();

            if(Users.Count != 0)
            {
                Users.Clear();
            }

            foreach(var account in accounts)// raises event for each account. try batch adding for larger database
            {
                Users.Add(account);
            }
        }
        catch(Exception ex)
        {
            Debug.WriteLine(ex);
            await Shell.Current.DisplayAlert("ERROR!",$"DEBUG INFO: unable to get users: {ex.Message}","OK");
        }
        finally
        {
            IsBusy = false;
        }
    }
}

