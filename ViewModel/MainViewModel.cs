using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;

namespace SolarTracker.ViewModel;

public partial class MainViewModel : ObservableObject
{
    public MainViewModel() 
    {
        
    }
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(FullName))]
    string firstName;

    [ObservableProperty]
    string lastName;

    public string FullName => $"{firstName} {lastName}";

    [RelayCommand]
    static void Submit() 
    {
        Debug.WriteLine("DEBUG INFO: Submitted");
    }


}
