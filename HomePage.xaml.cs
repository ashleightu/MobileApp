//using ShoppingUI.ViewModels;

namespace ShoppingUI.Views;

public partial class HomePage : ContentPage
{
    HomeViewModel homeViewModel;
	public HomePage()
	{
		InitializeComponent();
        homeViewModel = new HomeViewModel(this.Navigation);
        BindingContext = homeViewModel;
    }
}