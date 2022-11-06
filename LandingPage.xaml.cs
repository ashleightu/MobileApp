using ShoppingUI.ViewModels;

namespace ShoppingUI;

public partial class LandingPage : ContentPage
{
    public LandingPage()
    {
        InitializeComponent();
        this.BindingContext = new LandingViewModel(this.Navigation);
    }

    //private void OnClick(object sender, EventArgs e)
    //{
    //    Navigation.PushAsync(new LoginPage());
    //}
    
}