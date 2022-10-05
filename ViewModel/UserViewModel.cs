using SolarTracker.Services;

namespace SolarTracker.ViewModel;

public partial class UserViewModel : BaseViewModel
{
    public ObservableCollection<User> Users { get; } = new();
    UserService userService;
    public UserViewModel(UserService userService)
    {
        Title = "User viewModel";
        this.userService = userService;
    }

    [RelayCommand]
    async Task GoToDetails(User user)
    {
        this.Title = "yo mama";

        Debug.WriteLine("DEBUG INFO: GoToLoginPageCommand");

        if (user == null)
            return;

        await Shell.Current.GoToAsync("LoginPage", new Dictionary<string, object>
        {
            { "User", user }
        });

    }

    [RelayCommand]
    async Task GetUsersAsync()
    {

        Debug.WriteLine("DEBUG INFO: GetUsersAsync");
        if (IsBusy)
            return;

        try
        {
            IsBusy = true;
            var users = await userService.GetUsers();

            if (Users.Count != 0)
                Users.Clear();

            foreach (var user in users)
                Users.Add(user);

        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Unable to get monkeys: {ex.Message}");
            await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
        }
        finally
        {
            IsBusy = false;
        }

    }
}