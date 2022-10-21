using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using SolarTracker.Services;

namespace SolarTracker.ViewModel;

public partial class UserViewModel : BaseViewModel
{
    public ObservableCollection<User> Users { get; } = new();
    public ISeries[] Series { get; set; }

    UserService userService;
    public UserViewModel(UserService userService)
    {
        Title = "User viewModel";
        this.userService = userService;
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
            Debug.WriteLine($"Unable to get users: {ex.Message}");
            await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
        }
        finally
        {
            IsBusy = false;
        }

    }

    [RelayCommand]
    async Task GetDayProductionAsync()
    {

        Debug.WriteLine("DEBUG INFO: GetDayProductionAsync");
        if (IsBusy)
            return;

        try
        {
            IsBusy = true;

            Series = new ISeries[]
            {
                new LineSeries<double>
                {
                    Values = await userService.GetDayProduction(),
                    Fill = null
                }
            };

        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Unable to get users day usage: {ex.Message}");
            await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
        }
        finally
        {
            IsBusy = false;
        }

    }

    [RelayCommand]
    async Task GoToAboutPage(User user)
    {
        this.Title = "";

        Debug.WriteLine("DEBUG INFO: GoToAboutPageCommand");

        if (user == null)
            return;

        await Shell.Current.GoToAsync("AboutPage", new Dictionary<string, object>
        {
            { "User", user }
        });

    }
}