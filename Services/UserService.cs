using SolarTracker.Model;
using System.Net.Http.Json;
using System.Text.Json;

namespace SolarTracker.Services;

public class UserService
{
    List<User> userList = new();

    public async Task<List<User>> GetUsers()
    {

        Debug.WriteLine("DEBUG INFO: GetUsers");

        if (userList?.Count > 0)
            return userList;

        using var stream = await FileSystem.OpenAppPackageFileAsync("accountdata.json");
        using var reader = new StreamReader(stream);
        var contents = await reader.ReadToEndAsync();
        userList = JsonSerializer.Deserialize<List<User>>(contents);

        return userList;

    }

    public async Task<double[]> GetDayProduction()
    {

        Debug.WriteLine("DEBUG INFO: GetDayProductionAsync");

        double[] dayProduction = new double[1];

        if (userList?.Count > 0)
            return dayProduction;

        using var stream = await FileSystem.OpenAppPackageFileAsync("accountdata.json");
        using var reader = new StreamReader(stream);
        var contents = await reader.ReadToEndAsync();
        userList = JsonSerializer.Deserialize<List<User>>(contents);

        dayProduction = userList[0].Day;

        return dayProduction;

    }
}
