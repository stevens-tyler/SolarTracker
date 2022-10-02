using SolarTracker.Model;
using System.Net.Http.Json;
using System.Text.Json;

namespace SolarTracker.Services;

public class UserService
{
    List<User> userList = new();
    public async Task<List<User>> GetUsers()
    {

        if (userList?.Count > 0)
            return userList;

        //var url = "#";

        //var response = await httpClient.GetAsync(url);

        //if(response.IsSuccessStatusCode)
        //{
        //    userList = await response.Content.ReadFromJsonAsync<List<Users>>();
        //}

        using var stream = await FileSystem.OpenAppPackageFileAsync("accountdata.json");
        using var reader = new StreamReader(stream);
        var contents = await reader.ReadToEndAsync();
        userList = JsonSerializer.Deserialize<List<User>>(contents);

        return userList;

    }
}
