﻿using SolarTracker.ViewModel;
namespace SolarTracker.View;

public partial class MainPage : ContentPage
{
	//int count = 0;

	public MainPage(UserViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
		
	}

	//private void OnCounterClicked(object sender, EventArgs e)
	//{
	//	count++;

	//	if (count == 1)
	//		CounterBtn.Text = $"Clicked {count} time";
	//	else
	//		CounterBtn.Text = $"Clicked {count} times";

	//	SemanticScreenReader.Announce(CounterBtn.Text);
	//}
}

