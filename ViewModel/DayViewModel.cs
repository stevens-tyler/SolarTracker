using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using SolarTracker.Model;
using SolarTracker.Services;
using static Android.Icu.Text.CaseMap;

namespace SolarTracker.ViewModel;

public partial class DayViewModel : BaseViewModel

{
    public ObservableCollection<User> Users { get; } = new();

    public UserService userService;
   

    public DayViewModel(UserService userService)
    {
        Title = "Day View Model";
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

}
