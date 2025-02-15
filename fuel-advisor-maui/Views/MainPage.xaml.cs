using System.Collections.ObjectModel;
using fuel_advisor_maui.ViewModels;

namespace fuel_advisor_maui.Views;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
        InitializeComponent();
        BindingContext = new MainPageViewModel();
    }
}

