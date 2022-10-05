namespace SolarTracker.View;

public partial class MainPage : ContentPage
{
    public MainPage(UserViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
